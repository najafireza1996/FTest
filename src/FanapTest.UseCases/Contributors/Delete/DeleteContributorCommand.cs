using Ardalis.Result;
using Ardalis.SharedKernel;

namespace FanapTest.UseCases.Contributors.Delete;

public record DeleteContributorCommand(int ContributorId) : ICommand<Result>;
