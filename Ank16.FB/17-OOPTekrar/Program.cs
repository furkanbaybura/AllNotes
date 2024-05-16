namespace _17_OOPTekrarProduct
{
	internal class Program
	{
		static void Main(string[] args)
		{
			
		}

	}
	public interface IEntity
	{
		public int Id { get; set; }
	}
	public interface IRepository<T> where T : IEntity
	{
		List<T> GetAll();
		void Add(T entity);
		void Update (T entity);
		void Delete (int id);

	}
	public abstract class BaseRepo<T> : IRepository<T> where T : IEntity
	{
		protected List<T> DataSet = new List<T>
		{

		}
		public void Add(T entity)
		{
			DataSet.Add(entity);
		}

		public void Delete(int id)
		{
			foreach (var item in DataSet)
			{
				if (item.Id == id)
				{
					DataSet.Remove(item);
					return;

				}

			}

		}

		public List<T> GetAll()
		{
			return DataSet;
			
		}

		public void Update(T entity)
		{
			foreach (var item in DataSet)
			{
				if (item.Id==entity.Id)
				{

					DataSet.Remove(item);
					DataSet.Add(entity);
					return;

				}

			}

		}
	}
}