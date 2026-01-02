using Orders.Shared.DTOs;
using Orders.Shared.Entities;
using Orders.Shared.Responses;

namespace Orders.Backend.UnitOfWork.Interfaces;

public interface IStatesUnitOfWork
{
    Task<ActionResponse<State>> GetAsync(int id);

    Task<ActionResponse<IEnumerable<State>>> GetAsync(PaginationDTO pagination);

    Task<ActionResponse<IEnumerable<State>>> GetAsync();

    Task<ActionResponse<int>> GetTotalRecordsAsync(PaginationDTO pagination);
}