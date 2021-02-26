using Core.Utilities.Result;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IImageService
    {
        IDataResult<List<Image>> GetAll();
        IDataResult<Image> GetById(int id);
        IResult Add(Image ımage);
        IResult Delete(Image ımage);
        IResult UpDate(Image ımage);
    }
}
