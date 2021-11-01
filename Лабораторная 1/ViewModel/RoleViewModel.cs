﻿using System;
using System.Collections.ObjectModel;
using Лабораторная_1.Model;

namespace Лабораторная_1.ViewModel
{
    public class RoleViewModel
    {
        public ObservableCollection<Role> ListRole { get; set; } = new
        ObservableCollection<Role>();
       

        public RoleViewModel()
        {
            this.ListRole.Add(new Role
            {
                Id = 1,
                NameRole = "Директор"
            });
            this.ListRole.Add(new Role
            {
                Id = 2,
                NameRole = "Бухгалтер"
            });
            this.ListRole.Add(new Role
            {
                Id = 3,
                NameRole = "Менеджер"
            });

        }
        public int MaxId()
        {
            int max = 0;
            foreach (var r in this.ListRole)
            {
                if (max < r.Id)
                {
                    max = r.Id;
                };
            }
            return max;
        }
        /// <summary>
        /// Нахождение максимального Id
        /// </summary>
        /// <returns></returns>

    }
}