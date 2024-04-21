namespace DIASP
{
	public class UserService
	{
		public readonly IUserRepository _repository;

		public UserService() {
			_repository = new UserRepository();
		}
		public UserService(IUserRepository repository) {
			_repository = repository;
		}
	}
}
