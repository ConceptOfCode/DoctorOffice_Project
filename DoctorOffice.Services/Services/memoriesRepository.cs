﻿using DoctorOffice.DataLayer;
using DoctorOffice.Domains;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using DoctorOffice.ViewModels;
using System.Linq;

namespace DoctorOffice.Services
{
    public class memoriesRepository : IMemoriesRepository
    {
        ProjectContext db;

        public memoriesRepository(ProjectContext DB)
        {
            this.db = DB;
        }
        public async Task<IEnumerable<Memories>> getAllMemories()
        {
            return await Task.Run(() => db.Memories);
        }

        public async Task<Memories> getMemoriesById(int id)
        {
            return await db.Memories.FindAsync(id);
        }

        public async Task<bool> insertMemories(Memories Memories)
        {
            try
            {
                await db.Memories.AddAsync(Memories);
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public async Task<bool> editMemories(Memories Memories)
        {
            try
            {
                await Task.Run(() => db.Entry(Memories).State = EntityState.Modified);
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public async Task<bool> deleteMemories(Memories Memories)
        {
            try
            {
                await Task.Run(() => db.Entry(Memories).State = EntityState.Deleted);
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public async Task<bool> deleteMemories(int id)
        {
            try
            {
                Memories find = await getMemoriesById(id);
                await deleteMemories(find);
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public async Task saveChanges()
        {
            await db.SaveChangesAsync();
        }

        public async void Dispose()
        {
            await db.DisposeAsync();
        }

        public async Task<IEnumerable<MemoriesInformation_ViewModel>> getAllMemoriesInformation()
        {
            return await Task.Run(() => db.Memories.Select(s => new MemoriesInformation_ViewModel()
            {
                memoriesID = s.MemoriesID,
                patientsID = s.patientsID,
                fullNamePatient = s.Patients.firstName + " " + s.Patients.lastName,
                PatientsNationalNumber = s.Patients.nationalNumber,
                memoriesTitle = s.memoriesTitle,
                memoriesFullText = s.fullTextMemories,
                createDateTime = s.createDate,
                likeCount = s.likeCount
            }));
        }

        public async Task<IEnumerable<Memories>> getEnableMemories()
        {
            return await Task.Run(() => db.Memories.Where(w => w.memoriesTitle.Contains("$%#")));
        }
    }
}
