using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VKTok.Model
{
    public class FriendsItem
    {

        /// <summary>
        /// 
        /// </summary>
        public int id { get; set; }
    }

    public class AnswersItem
    {

        /// <summary>
        /// 
        /// </summary>
        public int id { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public float rate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string text { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int votes { get; set; }
    }

    public class PointsItem
    {

        /// <summary>
        /// 
        /// </summary>
        public string color { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int position { get; set; }
    }

    public class Background
    {

        /// <summary>
        /// 
        /// </summary>
        public int angle { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string color { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int id { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string name { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public List<PointsItem> points { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string type { get; set; }
    }

    public class Poll
    {

        /// <summary>
        /// 
        /// </summary>
        public string multiple { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int end_date { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string closed { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string is_board { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string can_edit { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string can_vote { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string can_report { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string can_share { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int created { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int id { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int owner_id { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string question { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int votes { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string disable_unvote { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string anonymous { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public List<FriendsItem> friends { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public List<string> answer_ids { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string embed_hash { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public List<AnswersItem> answers { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int author_id { get; set; }
        /// <summary>
        /// 
        /// </summary>
        //public Background background { get; set; }
    }

    public class VideoPreview
    {

        /// <summary>
        /// 
        /// </summary>
        public string src { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int width { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int height { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int file_size { get; set; }
    }

    public class Preview
    {

        /// <summary>
        /// 
        /// </summary>
        public Photo photo { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public VideoPreview video { get; set; }
    }

    public class Doc
    {

        /// <summary>
        /// 
        /// </summary>
        public int id { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int owner_id { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string title { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int size { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string ext { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int date { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int type { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string url { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Preview preview { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string access_key { get; set; }
    }

    public class Link
    {

        /// <summary>
        /// 
        /// </summary>
        public string url { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string title { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string caption { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string description { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Photo photo { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string is_favorite { get; set; }
    }

    public class ImageItem
    {

        /// <summary>
        /// 
        /// </summary>
        public int height { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string url { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int width { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int with_padding { get; set; }
    }

    public class First_frameItem
    {

        /// <summary>
        /// 
        /// </summary>
        public int height { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string url { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int width { get; set; }
    }

    public class Video
    {

        /// <summary>
        /// 
        /// </summary>
        public string access_key { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int can_comment { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int can_like { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int can_repost { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int can_subscribe { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int can_add_to_faves { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int can_add { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int comments { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int date { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string description { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int duration { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public List<ImageItem> image { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public List<First_frameItem> first_frame { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int width { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int height { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int id { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int owner_id { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string title { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string is_favorite { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string track_code { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string type { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int views { get; set; }
    }

    public class SizesItem
    {

        /// <summary>
        /// 
        /// </summary>
        public int height { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string url { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string type { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int width { get; set; }
    }

    public class Photo
    {

        /// <summary>
        /// 
        /// </summary>
        public int album_id { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int date { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int id { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int owner_id { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string has_tags { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string access_key { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int post_id { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public List<SizesItem> sizes { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string text { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int user_id { get; set; }
    }

    public class AttachmentsItem
    {
        public string type { get; set; }

        public Photo photo { get; set; }

        public Video video { get; set; }

        public Poll poll { get; set; }

        public Doc doc { get; set; }

        public Link link { get; set; }
    }

    public class Post_source
    {

        /// <summary>
        /// 
        /// </summary>
        public string type { get; set; }
    }

    public class Comments
    {

        /// <summary>
        /// 
        /// </summary>
        public int count { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int can_post { get; set; }
    }

    public class Likes
    {

        /// <summary>
        /// 
        /// </summary>
        public int count { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int user_likes { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int can_like { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int can_publish { get; set; }
    }

    public class Reposts
    {

        /// <summary>
        /// 
        /// </summary>
        public int count { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int user_reposted { get; set; }
    }

    public class Views
    {

        /// <summary>
        /// 
        /// </summary>
        public int count { get; set; }
    }

    public class Donut
    {

        /// <summary>
        /// 
        /// </summary>
        public string is_donut { get; set; }
    }

    public class ItemsItem
    {

        /// <summary>
        /// 
        /// </summary>
        public int source_id { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int date { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string can_doubt_category { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string can_set_category { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string post_type { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string text { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int marked_as_ads { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public List<AttachmentsItem> attachments { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Post_source post_source { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Comments comments { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Likes likes { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Reposts reposts { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Views views { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string is_favorite { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Donut donut { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public double short_text_rate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int post_id { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string type { get; set; }
    }

    public class Online_info
    {

        /// <summary>
        /// 
        /// </summary>
        public string visible { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string is_online { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string is_mobile { get; set; }
    }

    public class ProfilesItem
    {

        /// <summary>
        /// 
        /// </summary>
        public string first_name { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int id { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string last_name { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string can_access_closed { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string is_closed { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int sex { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string screen_name { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string photo_50 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string photo_100 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Online_info online_info { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int online { get; set; }
    }

    public class GroupsItem
    {

        /// <summary>
        /// 
        /// </summary>
        public int id { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string name { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string screen_name { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int is_closed { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string type { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string photo_50 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string photo_100 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string photo_200 { get; set; }
    }

    public class Response
    {

        /// <summary>
        /// 
        /// </summary>
        public List<ItemsItem> items { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public List<ProfilesItem> profiles { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public List<GroupsItem> groups { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string next_from { get; set; }
    }

    public class Root
    {

        /// <summary>
        /// 
        /// </summary>
        public Response response { get; set; }
    }


}
