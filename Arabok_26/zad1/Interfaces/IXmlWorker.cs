using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using zad1.Models;

namespace zad1.Interfaces
{
    public interface IXmlWorker
    {
        void Load(string xmlFilePath);
        void Add(Student student);
        void Delete(string LastName);
        Student FindBy(string LastName);
        List<Student> GetAll();

    }
}
