using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace ReflectionExample.WebApi.Services
{
    public interface ICreateExcelFileService
    {
        byte[] CreateExcelFileStream<T>(T data);
    }
}
