using Microsoft.AspNetCore.Mvc.Rendering;

namespace Razor_PartialView.Services
{
    public class GetListsUserInfo:IGetListsUserInfo
    {
        public MultiSelectList GetListHobbies()
        {
            List<string> listHobbies = new List<string>() { "Dancing","Travelling","Cooking", "Yoga", "Camping"};
            return new MultiSelectList(listHobbies,"Hobby");
        }

        public SelectList GetSelectedCity()
        {
            List<string> listCities = new List<string>() { "Kyiv", "Vinnytsia", "Cherkasy", "Lviv", "Chernivtsi" };
            return new SelectList(listCities, "Cities");
        }
    }
}
