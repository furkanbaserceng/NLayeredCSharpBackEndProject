
using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Core.DataAccess
{
    public interface IEntityRepository<T> where T:class,IEntity,new() //buradaki class demek referans tip istemesi demek,IEntity yada ondan türeyenler verilebilir ayrıca, ama new() vererek IEntity nin kendisini(soyut yapıyı) vermek de engelleniyor.
    {

        List<T> GetAll(Expression<Func<T,bool>> filter=null); //filtre vermesende olur dedik null vererek.filtre verilmemişse tüm datayı filtresiz,filtre verilmişse filtreye göre getirecek.business da çağırırken o filtreleri lambda expressionlarla verecez link gibi.
        T Get(Expression<Func<T, bool>> filter);  //listelenerek gelen veride üzerine tıklanıldığında detaylarına gidecek.filtre vermek zorunlu.

        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);

        // List<T> GetAllByCategory(int categoryId);  listelemede kullanılan Expression yapısıyla idye göre getir yada herhangi bir duruma göre getir demek için ayrı ayrı metod tanımlamaktan kurtaran bir yapı. Bu yüzden Expressionlarla kullanmak daha mantıklı.




    }
}
