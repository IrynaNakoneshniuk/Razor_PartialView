using Microsoft.AspNetCore.Mvc.Rendering;

namespace Razor_PartialView.Services
{
    public interface IGetListsUserInfo
    {
        MultiSelectList GetListHobbies();
        SelectList GetSelectedCity();
    }
}