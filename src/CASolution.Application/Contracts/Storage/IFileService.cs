using Ardalis.Result;
using Microsoft.AspNetCore.Http;
using System;
using System.Threading.Tasks;

namespace CASolution.Application.Contracts.Storage
{
    public interface IFileService
    {
        public Task<Result<string>> StoreFile(string fileName, IFormFile file);
        public Task<Result<IFormFile>> RetreiveFile(string fileKey);
        public Task<Result<IFormFile>> RemoveFile(string fileKey);
        public Task<Result<IFormFile>> UpdateFile(string fileKey, IFormFile file);
    }
}
