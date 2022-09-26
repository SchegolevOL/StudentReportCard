using StudentReportCard.App;

var db = new DB();
string last;
string first;
string patronymic;
int assessment;
string id;

do
{
    Console.WriteLine("");
    id = Console.ReadLine();

    switch (id)
    {
        case "1":
            var student = new StudentReport();
            Console.WriteLine("Enter Last name: ");
            student.LastName = Console.ReadLine();
            Console.WriteLine("Enter First name: ");
            student.FirstName = Console.ReadLine();
            Console.WriteLine("Enter Patronymic: ");
            student.Patronymic = Console.ReadLine();
            Console.WriteLine("Enter Assessment: ");
            student.Assessment = Int32.Parse(Console.ReadLine());
            student.Date = DateTime.Now;
            db.TableStudetReports.Add(student);
            db.SaveChanges();
            break;

        case "2":
            Console.WriteLine("=================================================================================");
            foreach (var s in db.TableStudetReports)
            {
                Console.WriteLine($"| {s.Id}\t| {s.FirstName}\t| {s.LastName}\t| {s.Patronymic}\t| {s.Date}\t| {s.Assessment}\t|");
                Console.WriteLine("=================================================================================");
            }
            break;
        case "3":

            break;
        case "0":

            break;
        default:

            break;
    }
} while (id != "0");

