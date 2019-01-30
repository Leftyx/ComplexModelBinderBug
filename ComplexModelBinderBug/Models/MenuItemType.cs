using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public enum MenuItemType
    {
        // Token: 0x0400008B RID: 139
        Categories,
        // Token: 0x0400008C RID: 140
        Manufacturers = 20,
        // Token: 0x0400008D RID: 141
        Vendors = 30,
        // Token: 0x0400008E RID: 142
        Product = 40,
        // Token: 0x0400008F RID: 143
        Topics = 50,
        // Token: 0x04000090 RID: 144
        Blogs = 60,
        // Token: 0x04000091 RID: 145
        Forums = 70,
        // Token: 0x04000092 RID: 146
        News = 80,
        // Token: 0x04000093 RID: 147
        ProductTags = 85,
        // Token: 0x04000094 RID: 148
        ColumnsLayout = 150,
        // Token: 0x04000095 RID: 149
        RowsLayout,
        // Token: 0x04000096 RID: 150
        Column = 155,
        // Token: 0x04000097 RID: 151
        Row,
        // Token: 0x04000098 RID: 152
        Picture = 160,
        // Token: 0x04000099 RID: 153
        CustomLink = 200,
        // Token: 0x0400009A RID: 154
        HomePage = 300,
        // Token: 0x0400009B RID: 155
        CustomerInfo = 305,
        // Token: 0x0400009C RID: 156
        ContactUs = 310,
        // Token: 0x0400009D RID: 157
        NewProducts = 315,
        // Token: 0x0400009E RID: 158
        Blog = 320,
        // Token: 0x0400009F RID: 159
        NewsArchive = 325,
        // Token: 0x040000A0 RID: 160
        Boards = 330,
        // Token: 0x040000A1 RID: 161
        ManufacturerList = 335,
        // Token: 0x040000A2 RID: 162
        VendorList = 340,
        // Token: 0x040000A3 RID: 163
        ProductTagsAll = 345,
        // Token: 0x040000A4 RID: 164
        ProductSearch = 350,
        // Token: 0x040000A5 RID: 165
        ShoppingCart = 355,
        // Token: 0x040000A6 RID: 166
        Wishlist = 360,
        // Token: 0x040000A7 RID: 167
        CompareProducts = 365,
        // Token: 0x040000A8 RID: 168
        Checkout = 370,
        // Token: 0x040000A9 RID: 169
        Login = 375,
        // Token: 0x040000AA RID: 170
        Register = 380,
        // Token: 0x040000AB RID: 171
        Sitemap = 385,
        // Token: 0x040000AC RID: 172
        RecentlyViewedProducts = 390
    }
}
