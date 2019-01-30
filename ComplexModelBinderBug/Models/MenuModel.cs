using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace WebApplication1.Models
{
    // Token: 0x0200004B RID: 75
    public class MenuModel : BaseNopEntityModel
    {
        // Token: 0x060001D3 RID: 467 RVA: 0x00006260 File Offset: 0x00004460
        public MenuModel()
        {
            this.SupportedWidgetZones = new List<SelectListItem>();
            this.PredefinedPages = new List<SelectListItem>();
            this.Items = new List<MenuItemModel>();
            this.Settings = new MegaMenuSettingsModel();
            this.MappingToStores = new StoreMappingModel();
        }

        // Token: 0x17000080 RID: 128
        // (get) Token: 0x060001D4 RID: 468 RVA: 0x0000629F File Offset: 0x0000449F
        // (set) Token: 0x060001D5 RID: 469 RVA: 0x000062A7 File Offset: 0x000044A7
        public bool Enabled { get; set; }

        // Token: 0x17000081 RID: 129
        // (get) Token: 0x060001D6 RID: 470 RVA: 0x000062B0 File Offset: 0x000044B0
        // (set) Token: 0x060001D7 RID: 471 RVA: 0x000062B8 File Offset: 0x000044B8
        public string Name { get; set; }

        // Token: 0x17000082 RID: 130
        // (get) Token: 0x060001D8 RID: 472 RVA: 0x000062C1 File Offset: 0x000044C1
        // (set) Token: 0x060001D9 RID: 473 RVA: 0x000062C9 File Offset: 0x000044C9
        public string CssClass { get; set; }

        // Token: 0x17000083 RID: 131
        // (get) Token: 0x060001DA RID: 474 RVA: 0x000062D2 File Offset: 0x000044D2
        // (set) Token: 0x060001DB RID: 475 RVA: 0x000062DA File Offset: 0x000044DA
        public bool ShowDropdownsOnClick { get; set; }

        // Token: 0x17000084 RID: 132
        // (get) Token: 0x060001DC RID: 476 RVA: 0x000062E3 File Offset: 0x000044E3
        // (set) Token: 0x060001DD RID: 477 RVA: 0x000062EB File Offset: 0x000044EB
        public string WidgetZone { get; set; }

        // Token: 0x17000085 RID: 133
        // (get) Token: 0x060001DE RID: 478 RVA: 0x000062F4 File Offset: 0x000044F4
        // (set) Token: 0x060001DF RID: 479 RVA: 0x000062FC File Offset: 0x000044FC
        public bool ShowAclDisabledWarning { get; set; }

        // Token: 0x17000086 RID: 134
        // (get) Token: 0x060001E0 RID: 480 RVA: 0x00006305 File Offset: 0x00004505
        // (set) Token: 0x060001E1 RID: 481 RVA: 0x0000630D File Offset: 0x0000450D
        public IList<SelectListItem> SupportedWidgetZones { get; set; }

        // Token: 0x17000087 RID: 135
        // (get) Token: 0x060001E2 RID: 482 RVA: 0x00006316 File Offset: 0x00004516
        // (set) Token: 0x060001E3 RID: 483 RVA: 0x0000631E File Offset: 0x0000451E
        public IList<SelectListItem> PredefinedPages { get; set; }

        // Token: 0x17000088 RID: 136
        // (get) Token: 0x060001E4 RID: 484 RVA: 0x00006327 File Offset: 0x00004527
        // (set) Token: 0x060001E5 RID: 485 RVA: 0x0000632F File Offset: 0x0000452F
        public IList<MenuItemModel> Items { get; set; }

        // Token: 0x17000089 RID: 137
        // (get) Token: 0x060001E6 RID: 486 RVA: 0x00006338 File Offset: 0x00004538
        // (set) Token: 0x060001E7 RID: 487 RVA: 0x00006340 File Offset: 0x00004540
        public MegaMenuSettingsModel Settings { get; set; }

        // Token: 0x1700008A RID: 138
        // (get) Token: 0x060001E8 RID: 488 RVA: 0x00006349 File Offset: 0x00004549
        // (set) Token: 0x060001E9 RID: 489 RVA: 0x00006351 File Offset: 0x00004551
        public StoreMappingModel MappingToStores { get; set; }

        // Token: 0x1700008B RID: 139
        // (get) Token: 0x060001EA RID: 490 RVA: 0x0000635A File Offset: 0x0000455A
        // (set) Token: 0x060001EB RID: 491 RVA: 0x00006362 File Offset: 0x00004562
        public bool LimitedToStores { get; set; }
    }
}
