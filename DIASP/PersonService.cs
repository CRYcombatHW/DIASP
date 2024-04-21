namespace DIASP
{
	public class PersonService
	{
		public readonly IPersonRepository _repository;

		public PersonService() {
			_repository = new PersonRepository();
		}
		public PersonService(IPersonRepository repository) {
			_repository = repository;
		}
	}
}
