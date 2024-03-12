using Ardalis.Result;
using Ardalis.SharedKernel;

namespace FanapTest.UseCases.Contributors.Get;

public record GetContributorQuery(int ContributorId) : IQuery<Result<ContributorDTO>>;
