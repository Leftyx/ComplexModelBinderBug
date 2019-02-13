using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace ComplexModelBinderBug.Models
{
    public class MenuItemModel : BaseNopEntityModel, ICloneable
    {
        // Token: 0x060001A5 RID: 421 RVA: 0x00005F09 File Offset: 0x00004109
        public MenuItemModel()
        {
            this.SubItems = new List<MenuItemModel>();
            this.SelectedCustomerRoleIds = new List<int>();
        }

        // Token: 0x1700006A RID: 106
        // (get) Token: 0x060001A6 RID: 422 RVA: 0x00005F3D File Offset: 0x0000413D
        // (set) Token: 0x060001A7 RID: 423 RVA: 0x00005F45 File Offset: 0x00004145
        public MenuItemType Type { get; set; }

        // Token: 0x1700006B RID: 107
        // (get) Token: 0x060001A8 RID: 424 RVA: 0x00005F4E File Offset: 0x0000414E
        // (set) Token: 0x060001A9 RID: 425 RVA: 0x00005F56 File Offset: 0x00004156
        public string TypeName { get; set; }

        // Token: 0x1700006C RID: 108
        // (get) Token: 0x060001AA RID: 426 RVA: 0x00005F5F File Offset: 0x0000415F
        // (set) Token: 0x060001AB RID: 427 RVA: 0x00005F67 File Offset: 0x00004167
        public string Title { get; set; }

        // Token: 0x1700006D RID: 109
        // (get) Token: 0x060001AC RID: 428 RVA: 0x00005F70 File Offset: 0x00004170
        // (set) Token: 0x060001AD RID: 429 RVA: 0x00005F78 File Offset: 0x00004178
        public string Url { get; set; }

        // Token: 0x1700006E RID: 110
        // (get) Token: 0x060001AE RID: 430 RVA: 0x00005F81 File Offset: 0x00004181
        // (set) Token: 0x060001AF RID: 431 RVA: 0x00005F89 File Offset: 0x00004189
        public bool OpenInNewWindow { get; set; }

        // Token: 0x1700006F RID: 111
        // (get) Token: 0x060001B0 RID: 432 RVA: 0x00005F92 File Offset: 0x00004192
        // (set) Token: 0x060001B1 RID: 433 RVA: 0x00005F9A File Offset: 0x0000419A
        public int DisplayOrder { get; set; }

        // Token: 0x17000070 RID: 112
        // (get) Token: 0x060001B2 RID: 434 RVA: 0x00005FA3 File Offset: 0x000041A3
        // (set) Token: 0x060001B3 RID: 435 RVA: 0x00005FAB File Offset: 0x000041AB
        public string CssClass { get; set; }

        // Token: 0x17000071 RID: 113
        // (get) Token: 0x060001B4 RID: 436 RVA: 0x00005FB4 File Offset: 0x000041B4
        // (set) Token: 0x060001B5 RID: 437 RVA: 0x00005FBC File Offset: 0x000041BC
        public int MaximumNumberOfEntities { get; set; }

        // Token: 0x17000072 RID: 114
        // (get) Token: 0x060001B6 RID: 438 RVA: 0x00005FC5 File Offset: 0x000041C5
        // (set) Token: 0x060001B7 RID: 439 RVA: 0x00005FCD File Offset: 0x000041CD
        public int NumberOfBoxesPerRow { get; set; }

        // Token: 0x17000073 RID: 115
        // (get) Token: 0x060001B8 RID: 440 RVA: 0x00005FD6 File Offset: 0x000041D6
        // (set) Token: 0x060001B9 RID: 441 RVA: 0x00005FDE File Offset: 0x000041DE
        public CatalogTemplate CatalogTemplate { get; set; }

        // Token: 0x17000074 RID: 116
        // (get) Token: 0x060001BA RID: 442 RVA: 0x00005FE7 File Offset: 0x000041E7
        // (set) Token: 0x060001BB RID: 443 RVA: 0x00005FEF File Offset: 0x000041EF
        public int ImageSize { get; set; }

        // Token: 0x17000075 RID: 117
        // (get) Token: 0x060001BC RID: 444 RVA: 0x00005FF8 File Offset: 0x000041F8
        // (set) Token: 0x060001BD RID: 445 RVA: 0x00006000 File Offset: 0x00004200
        public int EntityId { get; set; }

        // Token: 0x17000076 RID: 118
        // (get) Token: 0x060001BE RID: 446 RVA: 0x00006009 File Offset: 0x00004209
        // (set) Token: 0x060001BF RID: 447 RVA: 0x00006011 File Offset: 0x00004211
        public string WidgetZone { get; set; }

        // Token: 0x17000077 RID: 119
        // (get) Token: 0x060001C0 RID: 448 RVA: 0x0000601A File Offset: 0x0000421A
        // (set) Token: 0x060001C1 RID: 449 RVA: 0x00006022 File Offset: 0x00004222
        public decimal Width { get; set; }

        // Token: 0x17000078 RID: 120
        // (get) Token: 0x060001C2 RID: 450 RVA: 0x0000602B File Offset: 0x0000422B
        // (set) Token: 0x060001C3 RID: 451 RVA: 0x00006033 File Offset: 0x00004233
        public int ParentMenuItemId { get; set; }

        // Token: 0x17000079 RID: 121
        // (get) Token: 0x060001C4 RID: 452 RVA: 0x0000603C File Offset: 0x0000423C
        // (set) Token: 0x060001C5 RID: 453 RVA: 0x00006044 File Offset: 0x00004244
        public int? MenuId { get; set; }

        // Token: 0x1700007A RID: 122
        // (get) Token: 0x060001C6 RID: 454 RVA: 0x0000604D File Offset: 0x0000424D
        // (set) Token: 0x060001C7 RID: 455 RVA: 0x00006055 File Offset: 0x00004255
        public int DepthLevel { get; set; }

        // Token: 0x1700007B RID: 123
        // (get) Token: 0x060001C8 RID: 456 RVA: 0x0000605E File Offset: 0x0000425E
        // (set) Token: 0x060001C9 RID: 457 RVA: 0x00006066 File Offset: 0x00004266
        public bool IncludeInTopMenu { get; set; }

        public IList<MenuItemModel> SubItems { get; set; }

        // Token: 0x1700007E RID: 126
        // (get) Token: 0x060001CE RID: 462 RVA: 0x00006091 File Offset: 0x00004291
        // (set) Token: 0x060001CF RID: 463 RVA: 0x00006099 File Offset: 0x00004299
        public IList<int> SelectedCustomerRoleIds { get; set; }

        // Token: 0x1700007F RID: 127
        // (get) Token: 0x060001D0 RID: 464 RVA: 0x000060A2 File Offset: 0x000042A2
        // (set) Token: 0x060001D1 RID: 465 RVA: 0x000060AA File Offset: 0x000042AA
        public IList<SelectListItem> AvailableCustomerRoles { get; set; }

        // Token: 0x060001D2 RID: 466 RVA: 0x000060B4 File Offset: 0x000042B4
        public object Clone()
        {
            MenuItemModel menuItemModel = new MenuItemModel
            {
                Id = this.Id,
                Type = this.Type,
                TypeName = this.TypeName,
                Title = this.Title,
                Url = this.Url,
                OpenInNewWindow = this.OpenInNewWindow,
                DisplayOrder = this.DisplayOrder,
                CssClass = this.CssClass,
                MaximumNumberOfEntities = this.MaximumNumberOfEntities,
                NumberOfBoxesPerRow = this.NumberOfBoxesPerRow,
                CatalogTemplate = this.CatalogTemplate,
                ImageSize = this.ImageSize,
                EntityId = this.EntityId,
                WidgetZone = this.WidgetZone,
                Width = this.Width,
                ParentMenuItemId = this.ParentMenuItemId,
                MenuId = this.MenuId,
                DepthLevel = this.DepthLevel,
                IncludeInTopMenu = this.IncludeInTopMenu
            };

            IList<MenuItemModel> list = new List<MenuItemModel>();

            foreach (MenuItemModel menuItemModel2 in this.SubItems)
            {
                list.Add((MenuItemModel)menuItemModel2.Clone());
            }
            menuItemModel.SubItems = list;

            return menuItemModel;
        }
    }
}
