using RaveshePajhoohesh_Console.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaveshePajhoohesh_Console.Business
{
    public class UniversityManager
    {
        // Add teacher
        static void AddTeacher(List<Teacher> teachers)
        {
            Console.WriteLine("Enter Teacher ID:");
            int teacherID = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Teacher Name:");
            string teacherName = Console.ReadLine();
            Console.WriteLine("Enter Teacher Subject:");
            string subject = Console.ReadLine();
            teachers.Add(new Teacher { TeacherID = teacherID, TeacherName = teacherName, Subject = subject });
            Console.WriteLine("Teacher added successfully.");
        }

        // Update teacher
        static void UpdateTeacher(List<Teacher> teachers)
        {
            Console.WriteLine("Enter Teacher ID to update:");
            int teacherID = int.Parse(Console.ReadLine());
            var teacherToUpdate = teachers.First(teacher => teacher.TeacherID == teacherID);
            Console.WriteLine("Enter Teacher Name:");
            teacherToUpdate.TeacherName = Console.ReadLine();
            Console.WriteLine("Enter Teacher Subject:");
            teacherToUpdate.Subject = Console.ReadLine();
            Console.WriteLine("Teacher updated successfully.");
        }

        // Delete teacher
        static void DeleteTeacher(List<Teacher> teachers)
        {
            Console.WriteLine("Enter Teacher ID to delete:");
            int teacherID = int.Parse(Console.ReadLine());
            var teacherToDelete = teachers.First(teacher => teacher.TeacherID == teacherID);
            teachers.Remove(teacherToDelete);
            Console.WriteLine("Teacher deleted successfully.");
        }

        // Add student
        static void AddStudent(List<Student> students)
        {
            Console.WriteLine("Enter Student ID:");
            int studentID = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Student Name:");
            string studentName = Console.ReadLine();
            Console.WriteLine("Enter Student Course:");
            string course = Console.ReadLine();
            students.Add(new Student { StudentID = studentID, StudentName = studentName, Course = course });
            Console.WriteLine("Student added successfully.");
        }

        // Update student
        static void UpdateStudent(List<Student> students)
        {
            Console.WriteLine("Enter Student ID to update:");
            int studentID = int.Parse(Console.ReadLine());
            var studentToUpdate = students.First(student => student.StudentID == studentID);
            Console.WriteLine("Enter Student Name:");
            studentToUpdate.StudentName = Console.ReadLine();
            Console.WriteLine("Enter Student Course:");
            studentToUpdate.Course = Console.ReadLine();
            Console.WriteLine("Student updated successfully.");
        }

        // Delete student
        static void DeleteStudent(List<Student> students)
        {
            Console.WriteLine("Enter Student ID to delete:");
            int studentID = int.Parse(Console.ReadLine());
            var studentToDelete = students.First(student => student.StudentID == studentID);
            students.Remove(studentToDelete);
            Console.WriteLine("Student deleted successfully.");
        }

        // Add lesson
        static void AddLesson(List<Teacher> teachers, List<Student> students, List<Lesson> lessons)
        {
            Console.WriteLine("Enter Lesson ID:");
            int lessonID = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Lesson Name:");
            string lessonName = Console.ReadLine();
            Console.WriteLine("Enter Teacher ID:");
            int teacherID = int.Parse(Console.ReadLine());
            var teacher = teachers.FirstOrDefault(t => t.TeacherID == teacherID);
            Console.WriteLine("Enter Student ID:");
            int studentID = int.Parse(Console.ReadLine());
            var student = students.FirstOrDefault(s => s.StudentID == studentID);
            if (teacher != null && student != null)
            {
                lessons.Add(new Lesson { LessonID = lessonID, LessonName = lessonName, TeacherID = teacherID, StudentID = studentID });
                Console.WriteLine("Lesson added successfully.");
            }
            else
            {
                Console.WriteLine("Teacher or student not found.");
            }
        }

        // Update lesson
        static void UpdateLesson(List<Teacher> teachers, List<Student> students, List<Lesson> lessons)
        {
            Console.WriteLine("Enter Lesson ID to update:");
            int lessonID = int.Parse(Console.ReadLine());
            var lessonToUpdate = lessons.First(lesson => lesson.LessonID == lessonID);
            Console.WriteLine("Enter Lesson Name:");
            lessonToUpdate.LessonName = Console.ReadLine();
            Console.WriteLine("Enter Teacher ID:");
            int teacherID = int.Parse(Console.ReadLine());
            var teacher = teachers.FirstOrDefault(t => t.TeacherID == teacherID);
            Console.WriteLine("Enter Student ID:");
            int studentID = int.Parse(Console.ReadLine());
            var student = students.FirstOrDefault(s => s.StudentID == studentID);
            if (teacher != null && student != null)
            {
                lessonToUpdate.TeacherID = teacherID;
                lessonToUpdate.StudentID = studentID;
                Console.WriteLine("Lesson updated successfully.");
            }
            else
            {
                Console.WriteLine("Teacher or student not found.");
            }
        }

        // Delete lesson
        static void DeleteLesson(List<Lesson> lessons)
        {
            Console.WriteLine("Enter Lesson ID to delete:");
            int lessonID = int.Parse(Console.ReadLine());
            var lessonToDelete = lessons.First(lesson => lesson.LessonID == lessonID);
            lessons.Remove(lessonToDelete);
            Console.WriteLine("Lesson deleted successfully.");
        }

        // Display all teachers
        static void DisplayTeachers(List<Teacher> teachers)
        {
            Console.WriteLine("Teachers:");
            Console.WriteLine("ID\tName\tSubject");
            foreach (var teacher in teachers)
            {
                Console.WriteLine($"{teacher.TeacherID}\t{teacher.TeacherName}\t{teacher.Subject}");
            }
        }

        // Display all students
        static void DisplayStudents(List<Student> students)
        {
            Console.WriteLine("Students:");
            Console.WriteLine("ID\tName\tCourse");
            foreach (var student in students)
            {
                Console.WriteLine($"{student.StudentID}\t{student.StudentName}\t{student.Course}");
            }
        }

        // Display all lessons
        static void DisplayLessons(List<Teacher> teachers, List<Student> students, List<Lesson> lessons)
        {
            Console.WriteLine("Lessons:");
            Console.WriteLine("ID\tName\tTeacher\tStudent");
            foreach (var lesson in lessons)
            {
                var teacher = teachers.First(t => t.TeacherID == lesson.TeacherID);
                var student = students.First(s => s.StudentID == lesson.StudentID);
                Console.WriteLine($"{lesson.LessonID}\t{lesson.LessonName}\t{teacher.TeacherName}\t{student.StudentName}");
            }
        }

        public void InitializeData()
        {
            // Initialize data
            List<Teacher> teachers = new List<Teacher>();
            List<Student> students = new List<Student>();
            List<Lesson> lessons = new List<Lesson>();

            // Menu loop
            bool exit = false;
            while (!exit)
            {
                Console.WriteLine("Select an option:");
                Console.WriteLine("1. Add Teacher");
                Console.WriteLine("2. Update Teacher");
                Console.WriteLine("3. Delete Teacher");
                Console.WriteLine("4. Add Student");
                Console.WriteLine("5. Update Student");
                Console.WriteLine("6. Delete Student");
                Console.WriteLine("7. Add Lesson");
                Console.WriteLine("8. Update Lesson");
                Console.WriteLine("9. Delete Lesson");
                Console.WriteLine("10. Display Teachers");
                Console.WriteLine("11. Display Students");
                Console.WriteLine("12. Display Lessons");
                Console.WriteLine("0. Exit");

                int option = int.Parse(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        AddTeacher(teachers);
                        break;
                    case 2:
                        UpdateTeacher(teachers);
                        break;
                    case 3:
                        DeleteTeacher(teachers);
                        break;
                    case 4:
                        AddStudent(students);
                        break;
                    case 5:
                        UpdateStudent(students);
                        break;
                    case 6:
                        DeleteStudent(students);
                        break;
                    case 7:
                        AddLesson(teachers, students, lessons);
                        break;
                    case 8:
                        UpdateLesson(teachers, students, lessons);
                        break;
                    case 9:
                        DeleteLesson(lessons);
                        break;
                    case 10:
                        DisplayTeachers(teachers);
                        break;
                    case 11:
                        DisplayStudents(students);
                        break;
                    case 12:
                        DisplayLessons(teachers, students, lessons);
                        break;
                    case 0:
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Invalid option.");
                        break;
                }
            }
        }

    }
}
