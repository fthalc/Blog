using ProgrammersBlog.Entities.Concrete;
using ProgrammersBlog.Entities.Dtos;
using ProgrammersBlog.Shared.Utilities.Results.Abstract;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ProgrammersBlog.Services.Abstract
{
    public interface ICategoryService
        //Asekron yapı olduğu için Task ile yapmamız lazım.
    {
        Task<IDataResult<CategoryDto>> Get(int CategoryId);
        Task<IDataResult<CategoryListDto>> GetAll();//predicate vermiyoruz 
        Task<IDataResult<CategoryListDto>> GetAllByNonDeleted();
        Task<IDataResult<CategoryListDto>> GetAllByNonDeletedAndActive();
        Task<IResult> Add(CategoryAddDto categoryAddDto,string createdByName);//Data Transfer Object 
        Task<IResult> Update(CategoryUpdateDto categoryUpdateDto,string modifiedByName);
        Task<IResult> Delete(int categoryId,string modifiedByName);//Silinmiş gibi gösterir ama silinmez yanlışlık olduğunda geri alınsın diye.
        Task<IResult> HardDelete(int categoryId);//Gerçekten silmek için kullanılacak.
    }
}
