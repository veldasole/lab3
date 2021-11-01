using System.Windows;

using Лабораторная_1.ViewModel;
namespace Лабораторная_1.Helper
{
    public class FindRole
    {
        int id;
        public FindRole(int id)
        {
            this.id = id;
        }
        public bool RolePredicate(Лабораторная_1.Model.Role role)
        {
            return role.Id == id;
        }
    }
}