```mermaid
classDiagram
    Person <|-- Student
    Person <|-- Teacher
    Course o-- Student
    Course o-- Teacher

    class Person {
        <<abstract>>
        -string _id
        -string _name
        +string Id
        +string Name
        +Person(id: string, name: string)
        +DisplayInfo()* void
    }

    class Student {
        -double _score
        +double Score
        +Student(id: string, name: string, score: double)
        +GetGrade() string
        +DisplayInfo() void
    }

    class Teacher {
        +string Department
        +Teacher(id: string, name: string, department: string)
        +DisplayInfo() void
    }

    class Course {
        +string CourseCode
        +string CourseName
        +Teacher CourseInstructor
        -List~Student~ _students
        +Course(courseCode: string, courseName: string, instructor: Teacher)
        +AddStudent(student: Student) void
        +DisplayStats() void
    }