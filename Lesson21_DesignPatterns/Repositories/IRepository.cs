﻿using System.Collections.Generic;

namespace Lesson21_DesignPatterns.Repositories
{
    public interface IRepository<T>
    {
        T Get(int id);
        List<T> GetAll();
        void Add(T item);
        void Update(T item);
        void Delete(int id);
    }
}
