﻿using Microsoft.EntityFrameworkCore;
using StudentManagementSystem.API.Data;
using StudentManagementSystem.API.Interfaces;
using StudentManagementSystem.API.Models;

namespace StudentManagementSystem.API.Services
{
    public class InstructorService : IInstructorService
    {
        private readonly InstructorDbContext _context;

        public InstructorService(InstructorDbContext context)
        {
            _context = context;
        }

        public async Task<Instructor> AddInstructor(Instructor newInstructor)
        {
            var instructor = await _context.Instructors.AddAsync(newInstructor);
            await _context.SaveChangesAsync();
            return instructor.Entity;
        }

        public async Task<Instructor> DeleteInstructor(int id)
        {
            Instructor instructor = await _context.Instructors.FirstOrDefaultAsync(x => x.Id == id);
            _context.Instructors.Remove(instructor);
            await _context.SaveChangesAsync();

            return instructor;
        }

        public async Task<IList<Instructor>> GetAllInstructors()
        {
            return await _context.Instructors.ToListAsync();
        }

        public async Task<Instructor> GetInstructor(int id)
        {
            return await _context.Instructors.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<Instructor> UpdateInstructor(Instructor updatedInstructor)
        {
            Instructor instructor = await _context.Instructors
                .FirstOrDefaultAsync(x => x.Id == updatedInstructor.Id);

            instructor.FirstName = updatedInstructor.FirstName;
            instructor.Initials = updatedInstructor.Initials;
            instructor.LastName = updatedInstructor.LastName;

            _context.Instructors.Update(instructor);
            await _context.SaveChangesAsync();

            return instructor;
        }
    }
}
