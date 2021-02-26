using Business.Abstract;
using Business.ValidationRules.FluentValidation;
using Core.Aspect.Autofac.Validation;
using Core.Utilities.Business;
using Core.Utilities.Result;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class ImageManager : IImageService
    {
        IImageDal _ımageDal;
        ICarService _carService;

        public ImageManager(IImageDal ımageDal,ICarService carService)
        {
            _ımageDal = ımageDal;
            _carService = carService;
        }
        [ValidationAspect(typeof(ImageValidator))]
        public IResult Add(Image ımage)
        {
            var result = BusinessRules.Run(CheckCountPicturesOfCar(ımage.CarID));
            if (result != null)
            {
                return result;
            }
            _ımageDal.Add(ımage);
            return new SuccessResult();
        }

        public IResult Delete(Image ımage)
        {
            _ımageDal.Delete(ımage);
            return new SuccessResult();
        }

        public IDataResult<List<Image>> GetAll()
        {
            return new SuccessDataResult<List<Image>>(_ımageDal.GetAll());
        }

        public IDataResult<Image> GetById(int id)
        {
            return new SuccessDataResult<Image>(_ımageDal.Get(c => c.CarID == id));
        }
        public IResult UpDate(Image ımage)
        {
            _ımageDal.Update(ımage);
            return new SuccessResult();
        }
        private IResult CheckCountPicturesOfCar(int carID)
        {
            var result = _ımageDal.GetAll(c => c.CarID == carID).Count;
            if (result >= 5)
            {
                return new ErrorResult("kontol edildi");
            }
            return new SuccessResult();
        }
    }
}
