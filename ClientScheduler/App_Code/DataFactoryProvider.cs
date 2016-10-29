
using AutoMapper;

namespace ClientScheduler
{
    public class DataFactoryProvider
    {

        /// <summary>
        /// Maps the entity to model.
        /// </summary>
        /// <typeparam name="T">EF raw Entity</typeparam>
        /// <typeparam name="T2">Web API Model for consumption</typeparam>
        /// <returns></returns>
        public T2 MapEntityToModel<T, T2>(object entity)
        {

            var config = new MapperConfiguration(cfg => cfg.CreateMap<T, T2>());

            var mapper = config.CreateMapper();

            return mapper.Map<T, T2>( (T) entity );
        }


        /// <summary>
        /// Maps the model to entity.
        /// </summary>
        /// <typeparam name="T">Web API Model for consumption</typeparam>
        /// <typeparam name="T2">EF raw Entity</typeparam>
        /// <param name="model">The model.</param>
        /// <returns></returns>
        public T2 MapModelToEntity<T, T2>(object model)
        {

            var config = new MapperConfiguration(cfg => cfg.CreateMap<T, T2>());

            var mapper = config.CreateMapper();

            return mapper.Map<T, T2>((T)model);
        }

    }
}