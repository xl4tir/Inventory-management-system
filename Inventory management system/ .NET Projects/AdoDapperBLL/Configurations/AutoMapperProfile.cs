using AdoDapperBLL.DTO.Requests;
using AdoDapperBLL.DTO.Responses;
using AdoDapperDAL.Entities;
using AutoMapper;

namespace AdoDapperBLL.Configurations
{
    public class AutoMapperProfile : Profile
    {
        private void CreatePurchaseOrderProductMaps()
        {
            CreateMap<ProductSubRequest, PurchaseOrderProduct>();
            
            CreateMap<PurchaseOrderProduct, PurchaseOrderProductResponse>();
        }
        
        private void CreatePurchaseOrderMaps()
        {
            CreateMap<PurchaseOrderPostRequest, PurchaseOrder>();
            
            CreateMap<PurchaseOrder, PurchaseOrderResponse>();
        }
        
        private void CreateWarehouseProductMaps()
        {
            CreateMap<ProductSubRequest, WarehouseProduct>();
            
            CreateMap<WarehouseProduct, WarehouseProductResponse>();
        }
        
        private void CreateWarehouseMaps()
        {
            CreateMap<WarehouseRequest, Warehouse>();
            
            CreateMap<Warehouse, WarehouseResponse>();
            
            CreateMap<Warehouse, Protos.WarehouseResponse>();
        }

        public AutoMapperProfile()
        {
            CreatePurchaseOrderProductMaps();
            CreatePurchaseOrderMaps();
            CreateWarehouseProductMaps();
            CreateWarehouseMaps();
        }
    }
}
