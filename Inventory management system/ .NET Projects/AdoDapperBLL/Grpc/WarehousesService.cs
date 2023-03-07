using AdoDapperBLL.Protos;
using AdoDapperDAL.Entities;
using AdoDapperDAL.Repositories.Abstract;
using AutoMapper;
using Grpc.Core;

namespace AdoDapperBLL.Grpc;

public class WarehousesService : Warehouses.WarehousesBase
{
    private readonly IMapper _mapper;

    private readonly IWarehouseRepository _warehouseRepository;

    public WarehousesService(IMapper mapper, IWarehouseRepository warehouseRepository)
    {
        _mapper = mapper;
        _warehouseRepository = warehouseRepository;
    }

    public override async Task<WarehousesResponse> GetAll(GetAllWarehousesRequest request, ServerCallContext context)
    {
        var warehousesResponse = new WarehousesResponse();
        var warehouses = await _warehouseRepository.GetAllAsync();
            
        var mappedResults = 
            warehouses.Select(result => _mapper.Map<Warehouse, WarehouseResponse>(result)).ToList();

        warehousesResponse.Data.AddRange(mappedResults);
        return warehousesResponse;
    }

    public override async Task<WarehouseResponse> GetById(GetWarehouseByIdRequest request, ServerCallContext context)
    {
        var warehouse = await _warehouseRepository.GetByIdAsync(request.Id);
        return _mapper.Map<Warehouse, WarehouseResponse>(warehouse);
    }
}