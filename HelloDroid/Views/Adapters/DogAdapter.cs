using Android.Views;
using AndroidX.RecyclerView.Widget;
using Hello.Models;
using HelloDroid.Views.Collections;
using System.Collections.Generic;

namespace HelloDroid.Views.Adapters
{
    class DogAdapter : RecyclerView.Adapter
    {
        private List<Dog> _dogs;

        public DogAdapter(List<Dog> dogs)
        {
            _dogs = dogs;
        }

        public override int ItemCount => _dogs == null ? 0 : _dogs.Count;
        public override void OnBindViewHolder(RecyclerView.ViewHolder holder, int position)
        {
            DogCollectionViewHolder mv = holder as DogCollectionViewHolder;

            var title = _dogs[position];
            mv.ColorDog.SetBackgroundColor(title.ColorDog);
            mv.Name.Text = title.Name;
        }

        public override RecyclerView.ViewHolder OnCreateViewHolder(ViewGroup parent, int viewType)
        {
            var itemView = LayoutInflater.From(parent.Context).Inflate(Resource.Layout.item_list_dog, parent, false);

            return new DogCollectionViewHolder(itemView);
        }
    }
}