namespace DefaultNamespace
{
    public class GradingStudents
    {
        /*
    * Complete the 'gradingStudents' function below.
    *
    * The function is expected to return an INTEGER_ARRAY.
    * The function accepts INTEGER_ARRAY grades as parameter.
    */

        public static List<int> gradingStudents(List<int> grades)
        {
            List<int> roundedGrades = new List<int>();

            for(int i = 0; i < grades.Count; i++){
                var grade = grades[i];
                if(grade <   38 || grade % 5 < 3 ){
                    roundedGrades.Add(grade);
                }
                else
                    roundedGrades.Add(grade + 5 - grade % 5);
            

            }

            return roundedGrades;
        }
    }
}