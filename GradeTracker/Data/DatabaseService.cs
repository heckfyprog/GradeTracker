using System;
using SQLite;
using GradeTracker.Models;
using GradeTracker.Models.University;

namespace GradeTracker.Data
{
    internal class DatabaseService
    {
        public const string DatabaseFileName = "GradeTracker.db3";

        private readonly SQLiteAsyncConnection _database;

        public DatabaseService(string dbPath)
        {
            _database = new SQLiteAsyncConnection(dbPath);
            _database.CreateTableAsync<Course>().Wait();
            _database.CreateTableAsync<FieldOfStudy>().Wait();
            _database.CreateTableAsync<YearOfStudy>().Wait();
            _database.CreateTableAsync<Semester>().Wait();
            _database.CreateTableAsync<User>().Wait();
        }

        public Task<List<Course>> GetCoursesAsync() => _database.Table<Course>().ToListAsync();
        public Task<int> SaveCourseAsync(Course course) => _database.InsertOrReplaceAsync(course);
        public Task<int> DeleteCourseAsync(Course course) => _database.DeleteAsync(course);
    }
}
