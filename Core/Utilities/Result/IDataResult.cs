using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Result
{
    public interface IDataResult<T>:IResult
    {
        //Mesajla işlem sonucunu IResult içeriyor bu yüzden tekrar yazmak yerine buraya dahil ediyoruz.
        
        T Data { get; }
    }
}
