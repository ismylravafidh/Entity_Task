using ConsoleApp1.DAL;
using ConsoleApp1.Models;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {//Dərsdə yazdigimiz Student modeli ucun service mentiqi yazin
         //Ado.netde yazdigimiz kimi elave olaraq Group modeli elave edin.

            bool check = true;
            do
            {
                Console.WriteLine("\t\t------Group Menu------");
                Console.WriteLine(" 1. Group Create and Add Database");
                Console.WriteLine(" 0. Exit");
                Console.WriteLine("\n Qeyd : Group Yaratmaq Mutleqdir.");
                Console.Write("\n\n Enter : ");
                int resultGroup = Convert.ToInt32(Console.ReadLine());

                switch (resultGroup)
                {
                    case 0:
                        check = false;
                        break;
                    case 1:
                        GroupService groupService = new GroupService();
                        Group group = new Group();
                        Console.WriteLine(" Id = Automatic identity.");
                        Console.Write(" Group Name Enter : ");
                        group.Name=Console.ReadLine();
                        groupService.AddGroup(group);
                        Console.WriteLine("\n\t\t------Student Menu------");
                        Console.WriteLine(" 1. Group Menu");
                        Console.WriteLine(" 2. Student Create and Add Database");
                        Console.WriteLine(" 0. Exit");
                        Console.Write("\n\n Enter : ");
                        int resultStudent = Convert.ToInt32(Console.ReadLine());
                        switch (resultStudent)
                        {
                            case 1:
                                check = true;
                                break;
                            case 2:
                                StudentService studentService = new StudentService();
                                Student student = new Student();
                                Console.WriteLine(" Id = Automatic identity.");
                                Console.Write(" Student Name Enter : ");
                                student.Name = Console.ReadLine();
                                Console.Write(" Student Surname Enter : ");
                                student.Surname = Console.ReadLine();
                                Console.Write(" Student Age Enter : ");
                                student.Age = Convert.ToInt32(Console.ReadLine());
                                Console.Write(" Elave olunacaq Groupun Id-sini daxil Edin : ");
                                student.GroupsId = Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine(" Qeyd : Eger daxil etdiyiniz Id uygun Group Yoxdursa Student Elave Edilmeyecek.");
                                studentService.AddStudent(student);
                                break;
                            case 0:
                                check = false;
                                break;
                            default:
                                Console.WriteLine("Duzgun Daxil Et \n");
                                check = true;
                                break;
                        }
                        break;
                    default:
                        Console.WriteLine("Duzgun Daxil Et");
                        check = true;
                        break;

                }
            } while (check==true);




        }
    }
}