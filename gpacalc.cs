
string studentName = "Sophia Johnson";
string course1Name = "English 101";
string course2Name = "Algebra 101";
string course3Name = "Biology 101";
string course4Name = "Computer Science I";
string course5Name = "Psychology 101";

int course1Credit = 3;
int course2Credit = 3;
int course3Credit = 4;
int course4Credit = 4;
int course5Credit = 3;

int totalCreditHours = 0;
totalCreditHours = course1Credit + course2Credit + course3Credit + course4Credit + course5Credit;

int gradeA = 4;
int gradeB = 3;

int course1Grade = gradeA;
int course2Grade = gradeB;
int course3Grade = gradeB;
int course4Grade = gradeB;
int course5Grade = gradeA;
decimal totalGradePoints = 0m;
totalGradePoints += course2Credit * course2Grade;
totalGradePoints += course3Credit * course3Grade;
totalGradePoints += course4Credit * course4Grade;
totalGradePoints += course5Credit * course5Grade;
totalGradePoints += course1Credit * course1Grade;




Console.WriteLine($"Student: {studentName}\n");
Console.WriteLine("Course\t\t\tGrade\tCredit Hour\tGrade Points");
Console.WriteLine($"{course1Name}\t\t\t{course1Grade}\t\t{course1Credit}");
Console.WriteLine($"{course2Name}\t\t\t{course2Grade}\t\t{course2Credit}");
Console.WriteLine($"{course3Name}\t\t\t{course3Grade}\t\t{course3Credit}");
Console.WriteLine($"{course4Name}\t{course4Grade}\t\t{course4Credit}");
Console.WriteLine($"{course5Name}\t\t{course5Grade}\t\t{course5Credit}\n");


decimal gpa= (decimal) (totalGradePoints/ totalCreditHours);

int leaddigit = (int) gpa;
int fd= (int) ( gpa*10)%10;
int sd= (int) (gpa*100) %10;

Console.WriteLine($"Final GPA:\t\t\t{leaddigit}.{fd}{sd}");
