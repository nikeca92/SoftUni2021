﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassroomProject
{
    public class Classroom
    {

        public Classroom(int capacity)
        {
            Capacity = capacity;
            students = new List<Student>();
        }

        readonly List<Student> students;

        public int Capacity { get; }

        public int Count => students.Count;

      

        public string RegisterStudent(Student student)
        {
            if (Capacity <= Count)
            {
                return "No seats in the classroom";
            }
            students.Add(student);
            return $"Added student {student.FirstName} {student.LastName}";
        }

        public string DismissStudent(string firstName, string lastName)
        {
            if (students.Exists(x => x.FirstName == firstName && x.LastName == lastName))
            {
                students.Remove(students.FirstOrDefault(x => x.FirstName == firstName && x.LastName == lastName));

                return $"Dismissed student {firstName} {lastName}";
            }

            return "Student not found";

        }

        public string GetSubjectInfo(string subject)
        {
            var studentsSubject = students.Where(x => x.Subject == subject).ToList();
            if (studentsSubject.Count > 0)
            {
                var sb = new StringBuilder();
                sb.AppendLine($"Subject: {subject}");
                sb.AppendLine($"Students:");
                foreach (var student in studentsSubject)
                {
                    sb.AppendLine($"{student.FirstName} {student.LastName}");
                }

                return sb.ToString().TrimEnd();
            }

            return "No students enrolled for the subject";
        }

        public int GetStudentCount() => Count;

        public Student GetStudent(string firstName, string lastName) => students.FirstOrDefault(x => x.FirstName == firstName && x.LastName == lastName);

        
    }
}
