using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using DoctorOffice.Domains;
using DoctorOffice.ViewModels;

namespace DoctorOffice.Services
{
    public interface IMemoriesRepository : IDisposable
    {
        Task<IEnumerable<Memories>> getAllMemories();

        Task<Memories> getMemoriesById(int id);

        Task<bool> insertMemories(Memories Memories);

        Task<bool> editMemories(Memories Memories);

        Task<bool> deleteMemories(Memories Memories);

        Task<bool> deleteMemories(int id);

        Task saveChanges();

        Task<IEnumerable<MemoriesInformation_ViewModel>> getAllMemoriesInformation();

        Task<IEnumerable<Memories>> getEnableMemories();
    }
}
