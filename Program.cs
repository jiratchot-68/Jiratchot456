using System;
using System.Text;

namespace Jiratchot
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;

            Course currentCourse = null;
            bool isRunning = true;

            while (isRunning)
            {
                Console.WriteLine("\nระบบจัดการเกรด");
                Console.WriteLine("1. เปิดรายวิชาใหม่ (พร้อมข้อมูลอาจารย์)");
                Console.WriteLine("2. เพิ่มข้อมูลนักศึกษาและคะแนน");
                Console.WriteLine("3. แสดงผลข้อมูลและสถิติรายวิชา");
                Console.WriteLine("4. ออกจากระบบ");
                Console.Write("เลือกเมนู (1-4): ");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Console.WriteLine("\nข้อมูลอาจารย์ผู้สอน");
                        Console.Write("รหัสอาจารย์: ");
                        string tId = Console.ReadLine();
                        Console.Write("ชื่อ-นามสกุลอาจารย์: ");
                        string tName = Console.ReadLine();
                        Console.Write("สาขาวิชา: ");
                        string tDept = Console.ReadLine();
                        Teacher instructor = new Teacher(tId, tName, tDept);

                        Console.WriteLine("\nข้อมูลรายวิชา");
                        Console.Write("รหัสวิชา: ");
                        string code = Console.ReadLine();
                        Console.Write("ชื่อวิชา: ");
                        string name = Console.ReadLine();

                        currentCourse = new Course(code, name, instructor);
                        Console.WriteLine(">> เปิดรายวิชาและบันทึกข้อมูลอาจารย์สำเร็จ!");
                        break;
                    case "2":
                        if (currentCourse == null)
                        {
                            Console.WriteLine(">> กรุณาเปิดรายวิชาใหม่ก่อน (เมนู 1)");
                            break;
                        }
                        Console.Write("รหัสนักศึกษา: ");
                        string stuId = Console.ReadLine();
                        Console.Write("ชื่อ-นามสกุล: ");
                        string stuName = Console.ReadLine();
                        Console.Write("คะแนน (0-100): ");

                        if (double.TryParse(Console.ReadLine(), out double score))
                        {
                            try
                            {
                                Student newStudent = new Student(stuId, stuName, score);
                                currentCourse.AddStudent(newStudent);
                                Console.WriteLine(">> บันทึกข้อมูลนักศึกษาสำเร็จ!");
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine(">> ข้อผิดพลาด: {ex.Message}");
                            }
                        }
                        else
                        {
                            Console.WriteLine(">> กรุณากรอกคะแนนเป็นตัวเลขเท่านั้น");
                        }
                        break;
                    case "3":
                        if (currentCourse == null)
                        {
                            Console.WriteLine(">> ยังไม่มีข้อมูลรายวิชา");
                            break;
                        }
                        currentCourse.DisplayStats();
                        break;
                    case "4":
                        isRunning = false;
                        Console.WriteLine(">> ออกจากโปรแกรม...");
                        break;
                    default:
                        Console.WriteLine(">> กรุณาเลือกเมนูให้ถูกต้อง");
                        break;
                }
            }
        }
    }
}
