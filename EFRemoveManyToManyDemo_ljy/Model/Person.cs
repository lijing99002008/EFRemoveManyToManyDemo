using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;

namespace EFRemoveManyToManyDemo_ljy.Model
{
    public class Person
    {
        //public Person()
        //{
        //    this.Roles = new HashSet<Role>();
        //}
        //public int Id { get; set; }
        public string FullName { get; set; }

        public class Person_ItemMap : EntityTypeConfiguration<Person>
        {
            public Person_ItemMap()
            {

                //定义主键
                this.HasKey(t => new { t.FullName });

                //定义表之间的关系
                //HasMany(d => d.cp_style_item_option)
                //.WithRequired(d => d.cp_style_item)
                //.HasForeignKey(p => p.style_no);

                //HasMany(d => d.cp_style_item_option)
                //.WithRequired(d => d.cp_style_item)
                //.HasForeignKey(p => p.item_no);

                //定义表之间的关系
                //HasMany(d => d.cp_style_item_option)
                //.WithRequired(d => d.cp_style_item)
                //.Map(m => m.MapKey("style_no", "item_no"));

            }
        }
    }
}
