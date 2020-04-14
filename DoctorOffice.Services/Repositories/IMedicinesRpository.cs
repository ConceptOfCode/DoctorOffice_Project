using DoctorOffice.Domains;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DoctorOffice.Services
{
    public interface IMedicinesRpository : IDisposable
    {
        Task<IEnumerable<Medicine>> getAllMedicine();

        Task<Medicine> getMedicineById(int id);

        Task<bool> insertMedicine(Medicine medicine);

        Task<bool> editMedicine(Medicine medicine);

        Task<bool> deleteMedicine(Medicine medicine);

        Task<bool> deleteMedicine(int id);

        Task saveChanges();
    }
}
