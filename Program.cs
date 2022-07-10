
using Microsoft.Data.Sqlite;
using Avaliacao3BimLp3.Database;
using Avaliacao3BimLp3.Repositories;
using Avaliacao3BimLp3.Models;

    
        var databaseConfig = new DatabaseConfig();

        var databaseSetup = new DatabaseSetup(databaseConfig);



        // Routing
        var modelName = args[0];
        var modelAction = args[1];

        if (modelName == "Students")
        {
             var studentsRepository = new StudentsRepository(databaseConfig);

            if (modelAction == "List")
            {
                Console.WriteLine("List Students");
                foreach (var students in StudentsRepository.GetAll())
                {
                    Console.WriteLine("{0}, {1}, {2}, {3}", students.Registration, students.Name, students.City, students.Formed);
                }
            }
            if (modelAction == "New")
            {
                Console.WriteLine("New Registration");
                var registration = Convert.ToInt32(args[2]);
                var name = args[3];
                var city = args[4];
                var formed = args[5];

                var computer = new student(registration, name, city, formed);
                studentRepository.Save(student);
            }

            if(modelAction == "Show") 
            {
                var registration = Convert.ToInt32(args[2]);
                 if(studentRepository.ExistsById(id))
                {
                var computer = studentRepository.GetById(id);
                Console.WriteLine($"{student.registration}, {student.name}, {student.city}, {student.formed");
                }
                else
                {
                Console.WriteLine($"O Estudante {registration} não existe");
                }
            }

            if(modelAction == "Delete") 
            {
                Console.WriteLine("Delete Computer");
                var id = Convert.ToInt32(args[2]);

                 studentRepository.Delete(id);

                
            }
            if (modelAction == "Update")
            {
                Console.WriteLine("Update Computer");
                var registration = Convert.ToInt32(args[2]);
                var name = args[3];
                var city = args[4];
                var formed = args[5];

                var student = new Student(registration, name, city, formed);

                studentRepository.Update(student);
            }
        }
       
}

