using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DoctorOffice.Services;
using constantConcepts = DoctorOffice.Enums.constantConcepts;
using Newtonsoft.Json;
using DoctorOffice.Domains;

namespace DoctorOffice_Project.Areas.secretaryPanel.Controllers
{
    [Area("secretaryPanel")]
    public class MemoriesController : Controller
    {
        IMemoriesRepository memoriesRepository;
        public MemoriesController(IMemoriesRepository memories)
        {
            this.memoriesRepository = memories;
        }

        [Route("secretaryPanel/MemoriesList")]
        public async Task<IActionResult> Index()
        {
            //var data = await memoriesRepository.getAllMemoriesInformation();
            return await Task.Run(() => View());
        }

        [HttpGet("secretaryPanel/getListMemories")]
        public async Task<jsonResult> getMemoriesList()
        {
            var data = await memoriesRepository.getAllMemoriesInformation();
            if (data.Any())
            {
                return jsonResult.GetJsonResult((int)constantConcepts.httpStatus.successed, constantConcepts.httpStatus.successed.ToString(), "", JsonConvert.SerializeObject(data));
            }
            else
            {
                return jsonResult.GetJsonResult((int)constantConcepts.httpStatus.notFound, constantConcepts.httpStatus.notFound.ToString(), "", "");
            }
        }

        [HttpGet("secretaryPanel/getEnableMemories")]
        public async Task<jsonResult> getEnableMemories()
        {
            var data = await memoriesRepository.getEnableMemories();
            if (data.Any())
            {
                return jsonResult.GetJsonResult((int)constantConcepts.httpStatus.successed, constantConcepts.httpStatus.successed.ToString(), "", JsonConvert.SerializeObject(data));
            }
            else
            {
                return jsonResult.GetJsonResult((int)constantConcepts.httpStatus.notFound, constantConcepts.httpStatus.notFound.ToString(), "", "");
            }
        }

        [HttpGet("secretaryPanel/MemoriesDetails/{memoriesID}")]
        public async Task<IActionResult> Details(int memoriesID)
        {
            var data = await memoriesRepository.getMemoriesById(memoriesID);
            return View(data);
        }

        /// <summary>
        /// پارامتر اول که شناسه خاطره است و پارامتر دوم یعنی میخواهم با این خاطره چه کاری بکنی 
        /// به عنوان مثال
        /// اگر فالس بود یعنی قراره غیر فعالش کنی
        /// </summary>
        /// <param name="memoriesID"></param>
        /// <param name="whatDoing"></param>
        /// <returns></returns>
        [Route("secretaryPanel/rendering/{memoriesID}/{whatDoing}")]
        public async Task<IActionResult> renderingMemories(int memoriesID, bool whatDoing)
        {
            var memories = await memoriesRepository.getMemoriesById(memoriesID);
            //اگر دارای این نماد بود و به اینجا ارسال شده و فالس هم هست یعنی میخواهد از صفحه برداشته بشه
            if (memories.memoriesTitle.Contains("$%#") && whatDoing == false)
            {
                var memo = memories.memoriesTitle.Split("$%#");
                foreach (var item in memo)
                {
                    if (item != "$%#" && item != null && item != "")
                    {
                        memories.memoriesTitle = item;
                    }
                }

                var result = await memoriesRepository.editMemories(memories);
                if (result == true)
                {
                    await memoriesRepository.saveChanges();
                }
            }
            //اگر دارای نماد نیست و ترو هم هست یعنی میخواهد این نماد را بگیرد و به صفحه اضافه شود
            else if (!memories.memoriesTitle.Contains("$%#") && whatDoing == true)
            {
                memories.memoriesTitle = memories.memoriesTitle + "$%#";
                var result = await memoriesRepository.editMemories(memories);
                if (result == true)
                {
                    await memoriesRepository.saveChanges();
                }
            }

            return RedirectToAction("Index");
        }
    }
}