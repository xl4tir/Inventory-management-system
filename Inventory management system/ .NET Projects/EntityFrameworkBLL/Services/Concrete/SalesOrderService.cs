using AutoMapper;
using EntityFrameworkBLL.DTO.Requests;
using EntityFrameworkBLL.DTO.Responses;
using EntityFrameworkBLL.Protos;
using EntityFrameworkBLL.Services.Abstract;
using EntityFrameworkDAL.Entities;
using EntityFrameworkDAL.Repositories.Abstract;
using EntityFrameworkDAL.UnitOfWork.Abstract;

namespace EntityFrameworkBLL.Services.Concrete
{
    public class SalesOrderService : ISalesOrderService
    {
        private readonly IUnitOfWork _unitOfWork;

        private readonly IMapper _mapper;

        private readonly ISalesOrderRepository _salesOrderRepository;

        private readonly ISalesOrderProductRepository _salesOrderProductRepository;

        private readonly Products.ProductsClient _productsClient;

        private readonly Warehouses.WarehousesClient _warehousesClient;

        public SalesOrderService(IUnitOfWork unitOfWork, IMapper mapper, Products.ProductsClient productsClient,
            Warehouses.WarehousesClient warehousesClient)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _salesOrderRepository = unitOfWork.SalesOrderRepository;
            _salesOrderProductRepository = unitOfWork.SalesOrderProductRepository;
            _productsClient = productsClient;
            _warehousesClient = warehousesClient;
        }

        private async Task<SalesOrderResponse> ExtendForResponse(SalesOrder salesOrder)
        {
            var response = _mapper.Map<SalesOrder, SalesOrderResponse>(salesOrder);
            var warehouse =
                await _warehousesClient.GetByIdAsync(new GetWarehouseByIdRequest {Id = salesOrder.WarehouseId});
            response.WarehouseName = warehouse.Name;
            return response;
        }

        public async Task<IEnumerable<SalesOrderResponse>> GetAllAsync()
        {
            var warehouses = await _salesOrderRepository.GetAllAsync();
            var responses = new List<SalesOrderResponse>();
            foreach (var warehouse in warehouses)
            {
                responses.Add(await ExtendForResponse(warehouse));
            }

            return responses;
        }

        public async Task<SalesOrderResponse> GetByIdAsync(int id)
        {
            var warehouse = await _salesOrderRepository.GetByIdAsync(id);
            return await ExtendForResponse(warehouse);
        }

        public async Task<int> InsertAsync(SalesOrderPostRequest request)
        {
            await using var transaction = await _unitOfWork.DbContext.Database.BeginTransactionAsync();

            try
            {
                var entity = _mapper.Map<SalesOrderPostRequest, SalesOrder>(request);
                entity.OrderStatusCode = 1;
                entity.TotalPrice = await CountProductsTotalPrice(request.products);
                await _salesOrderRepository.InsertAsync(entity);
                await _unitOfWork.SaveChangesAsync();
                var insertedId = entity.Id;
                await AddSalesOrderProducts(insertedId, request.products);
                await SubtractFromWarehouseProducts(entity.WarehouseId, request.products);

                await transaction.CommitAsync();
                return insertedId;
            }
            catch (Exception)
            {
                await transaction.RollbackAsync();
                throw;
            }
        }

        public async Task UpdateAsync(SalesOrderRequest request)
        {
            var entity = _mapper.Map<SalesOrderRequest, SalesOrder>(request);
            await _salesOrderRepository.UpdateAsync(entity);
            await _unitOfWork.SaveChangesAsync();
        }

        public async Task DeleteByIdAsync(int id)
        {
            await _salesOrderRepository.DeleteByIdAsync(id);
            await _unitOfWork.SaveChangesAsync();
        }

        public async Task<IEnumerable<SalesOrderProductResponse>> GetSalesOrderProducts(int purchaseOrderId)
        {
            await _salesOrderRepository.GetByIdAsync(purchaseOrderId);

            var salesOrderProducts =
                await _salesOrderProductRepository.GetBySalesOrderIdAsync(purchaseOrderId);
            var responses = new List<SalesOrderProductResponse>();
            foreach (var salesOrderProduct in salesOrderProducts)
            {
                var response = _mapper.Map<SalesOrderProduct, SalesOrderProductResponse>(salesOrderProduct);
                var product = await _productsClient.GetByIdAsync(new GetProductByIdRequest {Id = response.ProductId});
                response.ProductName = product.Name;
                responses.Add(response);
            }

            return responses;
        }

        private async Task AddSalesOrderProducts(int purchaseOrderId, IEnumerable<ProductSubRequest> productRequests)
        {
            var productsToInsert = new List<SalesOrderProduct>();
            foreach (var productRequest in productRequests)
            {
                var product = _mapper.Map<ProductSubRequest, SalesOrderProduct>(productRequest);
                product.SalesOrderId = purchaseOrderId;
                productsToInsert.Add(product);
            }

            await _salesOrderProductRepository.InsertAsync(productsToInsert);
        }

        private async Task<decimal> CountProductsTotalPrice(IEnumerable<ProductSubRequest> productRequests)
        {
            decimal totalPrice = 0;
            // foreach (var productRequest in productRequests)
            // {
            //     var product = await _productRepository.GetByIdAsync(productRequest.ProductId);
            //     totalPrice += product.SellPrice * productRequest.SoldQuantity;
            // }
            throw new NotImplementedException("Implement using Rabbit MQ + http");

            return totalPrice;
        }

        // private async Task<WarehouseProduct?> GetWarehouseProductById(int warehouseId, int productId)
        // {
        //     var result = await _warehouseProductRepository.GetByWarehouseAndProductIdsAsync(warehouseId, productId);
        //     return result;
        // }

        private async Task SubtractFromWarehouseProducts(int warehouseId,
            IEnumerable<ProductSubRequest> productRequests)
        {
            var productsToUpdate = new List<WarehouseProduct>();
            throw new NotImplementedException("Implement using Rabbit MQ");
            // foreach (var productRequest in productRequests)
            // {
            //     var newWarehouseProduct = _mapper.Map<ProductSubRequest, WarehouseProduct>(productRequest);
            //     newWarehouseProduct.WarehouseId = warehouseId;
            //     var warehouseProduct =
            //         await GetWarehouseProductById(warehouseId, newWarehouseProduct.ProductId);
            //     if (warehouseProduct == null)
            //         throw new EntityNotFoundException(
            //             nameof(WarehouseProduct), warehouseId + ", " + newWarehouseProduct.ProductId);
            //     
            //     newWarehouseProduct.Quantity = warehouseProduct.Quantity - productRequest.SoldQuantity;
            //     if (newWarehouseProduct.Quantity < 0)
            //         throw new Exception("There is not enough quantity of the product in the warehouse");
            //     newWarehouseProduct.Id = warehouseProduct.Id;
            //     productsToUpdate.Add(newWarehouseProduct);
            // }
            // await _warehouseProductRepository.UpdateAsync(productsToUpdate);

            // await _unitOfWork.SaveChangesAsync();
        }
    }
}