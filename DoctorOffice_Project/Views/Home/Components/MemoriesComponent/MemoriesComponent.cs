using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DoctorOffice.Services;

namespace DoctorOffice_Project.Views.Home.Components.MemoriesComponent
{
    public class MemoriesComponent : ViewComponent
    {
        IMemoriesRepository memoriesRepository;
        public MemoriesComponent(IMemoriesRepository memories)
        {
            this.memoriesRepository = memories;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var data = await memoriesRepository.getEnableMemories();
            foreach (var item in data)
            {
                if (item.memoriesTitle.Contains("$%#"))//آیا آیتم من دارای این علامت است.این علامت به این معنی هست که مدیر خواسته نمایش داده بشه
                {
                    var memo = item.memoriesTitle.Split("$%#");//اگر هست کارنت رو با این علامت تکه تکه کن
                    foreach (var mems in memo)//روی تکه ها بچرخ
                    {
                        if (mems != "$%#" && mems != null && mems != "")//آیا تکه من مخالف این ها است
                        {
                            item.memoriesTitle = mems;//اگر هست این تکه همون عنوان اصلیه برو بذار جای قبلی بدون علامت
                        }
                    }
                }
            }
            return await Task.FromResult((IViewComponentResult)View("MemoriesComponent", data));
        }
    }
}
