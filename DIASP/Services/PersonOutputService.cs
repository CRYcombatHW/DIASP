using DIASP.Abstract;
using DIASP.Model;

namespace DIASP.Services
{
    public class PersonOutputService : IPersonOutputService
    {
        public void SaveToFile(Person person, string filePath) {
            File.WriteAllText(filePath, person.ToString());
        }
    }
}
