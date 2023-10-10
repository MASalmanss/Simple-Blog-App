namespace basics.Models

{

    public class Repository{
        private static readonly List<Course> _courses = new();

        static Repository(){
            _courses = new List<Course>()
            {
            new Course(){id = 1, Title = "Araç 1" , Description = "güzel bir araba" , Image ="1.jpg",Tags =new string[]{"motor","gövde"} , isActive =true , isHome = true},
            new Course(){id = 2, Title = "Araç 2" , Description = "güzel bir araba" , Image ="2.jpg" ,Tags =new string[]{"motor","gövde"} , isActive =true , isHome = true},
            new Course(){id = 3, Title = "Araç 3" , Description = "güzel bir araba" , Image = "3.jpg" , Tags =new string[]{"motor","gövde"} , isActive =true , isHome = true},
            new Course(){id = 4, Title = "Araç 4" , Description = "güzel bir araba" , Image ="1.jpg" , Tags =new string[]{"motor","gövde"} , isActive =true , isHome = true},
            };
        }

        public static List<Course> Courses
        {

            get{
                return _courses;
            }

        }

        public static Course? GetById(int? id){
            return _courses.FirstOrDefault(c => c.id == id);
        }

     }


}