using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telerik.WinControls.UI.Localization;

namespace NETLINK.UI
{
    public class VNRadGridLP : RadGridLocalizationProvider
    {
        public override string GetLocalizedString(string id)
        {
            switch (id)
            {
                case RadGridStringId.FilterFunctionBetween: return "Trong khoảng";
                case RadGridStringId.FilterFunctionContains: return "Chứa";
                case RadGridStringId.FilterFunctionDoesNotContain: return "Không chứa";
                case RadGridStringId.FilterFunctionEndsWith: return "Kết thúc bằng";
                case RadGridStringId.FilterFunctionEqualTo: return "Bằng";
                case RadGridStringId.FilterFunctionGreaterThan: return "Lớn hơn";
                case RadGridStringId.FilterFunctionGreaterThanOrEqualTo: return "Lớn hơn hoặc bằng";
                case RadGridStringId.FilterFunctionIsEmpty: return "Có sản phẩm nào";
                case RadGridStringId.FilterFunctionIsNull: return "Là không có giá trị";
                case RadGridStringId.FilterFunctionLessThan: return "Kém hơn";
                case RadGridStringId.FilterFunctionLessThanOrEqualTo: return "Kém hơn hoặc bằng";
                case RadGridStringId.FilterFunctionNoFilter: return "Không có bộ lọc";
                case RadGridStringId.FilterFunctionNotBetween: return "Không trong khoảng";
                case RadGridStringId.FilterFunctionNotEqualTo: return "Không bằng";
                case RadGridStringId.FilterFunctionNotIsEmpty: return "Không có sản phẩm nào";
                case RadGridStringId.FilterFunctionNotIsNull: return "Không phải là không giá trị";
                case RadGridStringId.FilterFunctionStartsWith: return "Bắt đầu bằng";
                case RadGridStringId.FilterFunctionCustom: return "Tùy chỉnh";

                case RadGridStringId.FilterOperatorBetween: return "Trong khoảng";
                case RadGridStringId.FilterOperatorContains: return "Chứa";
                case RadGridStringId.FilterOperatorDoesNotContain: return "Không chứa";
                case RadGridStringId.FilterOperatorEndsWith: return "Kết thúc bằng";
                case RadGridStringId.FilterOperatorEqualTo: return "Bằng";
                case RadGridStringId.FilterOperatorGreaterThan: return "Lớn hơn";
                case RadGridStringId.FilterOperatorGreaterThanOrEqualTo: return "Lớn hơn hoặc bằng";
                case RadGridStringId.FilterOperatorIsEmpty: return "Có sản phẩm";
                case RadGridStringId.FilterOperatorIsNull: return "Là không có giá trị";
                case RadGridStringId.FilterOperatorLessThan: return "Kém hơn";
                case RadGridStringId.FilterOperatorLessThanOrEqualTo: return "Kém hơn hoặc bằng";
                case RadGridStringId.FilterOperatorNoFilter: return "Không lọc";
                case RadGridStringId.FilterOperatorNotBetween: return "Không trong khoảng";
                case RadGridStringId.FilterOperatorNotEqualTo: return "không bằng";
                case RadGridStringId.FilterOperatorNotIsEmpty: return "Không có sản phẩm nào";
                case RadGridStringId.FilterOperatorNotIsNull: return "Không phải là không giá trị";
                case RadGridStringId.FilterOperatorStartsWith: return "Bắt đầu bằng";
                case RadGridStringId.FilterOperatorIsLike: return "Giống";
                case RadGridStringId.FilterOperatorNotIsLike: return "Không giống";
                case RadGridStringId.FilterOperatorIsContainedIn: return "Chứa trong";
                case RadGridStringId.FilterOperatorNotIsContainedIn: return "Không chứa trong";
                case RadGridStringId.FilterOperatorCustom: return "Tùy chỉnh";

                case RadGridStringId.CustomFilterMenuItem: return "Tùy chỉnh";
                case RadGridStringId.CustomFilterDialogCaption: return "Điều kiện lọc trên lưới [{0}]";
                case RadGridStringId.CustomFilterDialogLabel: return "Hiển thị ròng";
                case RadGridStringId.CustomFilterDialogRbAnd: return "Và";
                case RadGridStringId.CustomFilterDialogRbOr: return "Hoặc";
                case RadGridStringId.CustomFilterDialogBtnOk: return "Đồng ý";
                case RadGridStringId.CustomFilterDialogBtnCancel: return "Hủy bỏ";
                case RadGridStringId.CustomFilterDialogCheckBoxNot: return "Không";
                case RadGridStringId.CustomFilterDialogTrue: return "Đúng";
                case RadGridStringId.CustomFilterDialogFalse: return "Sai";

                case RadGridStringId.FilterMenuAvailableFilters: return "Có bộ lọc";
                case RadGridStringId.FilterMenuSearchBoxText: return "Tìm kiếm ...";
                case RadGridStringId.FilterMenuClearFilters: return "Xóa bộ lọc";
                case RadGridStringId.FilterMenuButtonOK: return "Đồng ý";
                case RadGridStringId.FilterMenuButtonCancel: return "Hủy bỏ";
                case RadGridStringId.FilterMenuSelectionAll: return "Tất cả";
                case RadGridStringId.FilterMenuSelectionAllSearched: return "Tát cả kết quả tìm thấy";
                case RadGridStringId.FilterMenuSelectionNull: return "Không có giá trị";
                case RadGridStringId.FilterMenuSelectionNotNull: return "Có giá trị";

                case RadGridStringId.FilterFunctionSelectedDates: return "Lọc bởi ngày đặc biệt:";
                case RadGridStringId.FilterFunctionToday: return "Hôm nay";
                case RadGridStringId.FilterFunctionYesterday: return "Hôm qua";
                case RadGridStringId.FilterFunctionDuringLast7days: return "Trong 7 ngày sau";

                case RadGridStringId.FilterLogicalOperatorAnd: return "Và";
                case RadGridStringId.FilterLogicalOperatorOr: return "Hoặc";
                case RadGridStringId.FilterCompositeNotOperator: return "Không";

                case RadGridStringId.DeleteRowMenuItem: return "Xóa bản ghi";
                case RadGridStringId.SortAscendingMenuItem: return "Sắp xếp tăng";
                case RadGridStringId.SortDescendingMenuItem: return "Sắp xếp giảm";
                case RadGridStringId.ClearSortingMenuItem: return "Xóa sắp xếp";
                case RadGridStringId.ConditionalFormattingMenuItem: return "Điều kiện định dạng";
                case RadGridStringId.GroupByThisColumnMenuItem: return "Nhóm bởi cột";
                case RadGridStringId.UngroupThisColumn: return "Không nhóm bởi cột";
                case RadGridStringId.ColumnChooserMenuItem: return "Chọn cột";
                case RadGridStringId.HideMenuItem: return "Ẩn cột";
                case RadGridStringId.HideGroupMenuItem: return "Ẩn nhóm";
                case RadGridStringId.UnpinMenuItem: return "Chốt cột";
                case RadGridStringId.UnpinRowMenuItem: return "Chốt bản ghi";
                case RadGridStringId.PinMenuItem: return "Trạng thái chốt";
                case RadGridStringId.PinAtLeftMenuItem: return "Pin ở bên trái";
                case RadGridStringId.PinAtRightMenuItem: return "Pin ở bên phải";
                case RadGridStringId.PinAtBottomMenuItem: return "Pin ở phía dưới";
                case RadGridStringId.PinAtTopMenuItem: return "Pin ở phía trên";
                case RadGridStringId.BestFitMenuItem: return "phù hợp nhất";
                case RadGridStringId.PasteMenuItem: return "Dán";
                case RadGridStringId.EditMenuItem: return "Sửa";
                case RadGridStringId.ClearValueMenuItem: return "Xóa giá trị";
                case RadGridStringId.CopyMenuItem: return "Copy";
                case RadGridStringId.CutMenuItem: return "Cắt";
                case RadGridStringId.AddNewRowString: return "Click thêm mới bản ghi";
                //case RadGridStringId.ConditionalFormattingSortAlphabetically: return "Sort columns alphabetically";
                case RadGridStringId.ConditionalFormattingCaption: return "Định dạng có điều kiện Quy định quản lý";
                case RadGridStringId.ConditionalFormattingLblColumn: return "Định dạng chỉ với tế bào";
                case RadGridStringId.ConditionalFormattingLblName: return "Rule name";
                case RadGridStringId.ConditionalFormattingLblType: return "Giá trị ô chọn";
                case RadGridStringId.ConditionalFormattingLblValue1: return "Giá trị 1";
                case RadGridStringId.ConditionalFormattingLblValue2: return "Giá trị 2";
                case RadGridStringId.ConditionalFormattingGrpConditions: return "Quy tắc";
                case RadGridStringId.ConditionalFormattingGrpProperties: return "Quy tắc thuộc tính";
                case RadGridStringId.ConditionalFormattingChkApplyToRow: return "Áp dụng định dạng này cho toàn bộ hàng";
                case RadGridStringId.ConditionalFormattingChkApplyOnSelectedRows: return "Áp dụng định dạng này nếu hàng được chọn";
                case RadGridStringId.ConditionalFormattingBtnAdd: return "Thêm mới quy tắc";
                case RadGridStringId.ConditionalFormattingBtnRemove: return "Loại bỏ";
                case RadGridStringId.ConditionalFormattingBtnOK: return "Đồng ý";
                case RadGridStringId.ConditionalFormattingBtnCancel: return "Hủy bỏ";
                case RadGridStringId.ConditionalFormattingBtnApply: return "Chấp nhận";
                case RadGridStringId.ConditionalFormattingRuleAppliesOn: return "Quy tắc áp dụng tới";
                case RadGridStringId.ConditionalFormattingCondition: return "Điều kiện";
                case RadGridStringId.ConditionalFormattingExpression: return "Biểu thức";
                case RadGridStringId.ConditionalFormattingChooseOne: return "[Chọn 1]";
                case RadGridStringId.ConditionalFormattingEqualsTo: return "Bằng [Giá trị 1]";
                case RadGridStringId.ConditionalFormattingIsNotEqualTo: return "Không bằng [Giá trị 1]";
                case RadGridStringId.ConditionalFormattingStartsWith: return "Bắt đầu bằng [Giá trị 1]";
                case RadGridStringId.ConditionalFormattingEndsWith: return "Kết thúc băng [Giá trị 1]";
                case RadGridStringId.ConditionalFormattingContains: return "Chứa [Giá trị 1]";
                case RadGridStringId.ConditionalFormattingDoesNotContain: return "Không chứa [Giá trị 1]";
                case RadGridStringId.ConditionalFormattingIsGreaterThan: return "Lơn hơn [Giá trị 1]";
                case RadGridStringId.ConditionalFormattingIsGreaterThanOrEqual: return "Lớn hơn hoặc bằng [Value1]";
                case RadGridStringId.ConditionalFormattingIsLessThan: return "Nhỏ hơn [Giá trị 1]";
                case RadGridStringId.ConditionalFormattingIsLessThanOrEqual: return "Nhỏ hơn hoặc bằng  [Giá trị 1]";
                case RadGridStringId.ConditionalFormattingIsBetween: return "Ở giữa [Giá trị 1] và [Giá trị 2]";
                case RadGridStringId.ConditionalFormattingIsNotBetween: return "Không ở giữa [Giá trị 1] và [Giá trị 2]";
                case RadGridStringId.ConditionalFormattingLblFormat: return "Định dạng";
                //case RadGridStringId.ConditionalFormattingBtnExpression: return "Expression editor";
                //case RadGridStringId.ConditionalFormattingTextBoxExpression: return "Expression";

                //case RadGridStringId.ConditionalFormattingPropertyGridCaseSensitive: return "CaseSensitive";
                //case RadGridStringId.ConditionalFormattingPropertyGridCellBackColor: return "CellBackColor";
                //case RadGridStringId.ConditionalFormattingPropertyGridCellForeColor: return "CellForeColor";
                //case RadGridStringId.ConditionalFormattingPropertyGridEnabled: return "Enabled";
                //case RadGridStringId.ConditionalFormattingPropertyGridRowBackColor: return "RowBackColor";
                //case RadGridStringId.ConditionalFormattingPropertyGridRowForeColor: return "RowForeColor";
                //case RadGridStringId.ConditionalFormattingPropertyGridRowTextAlignment: return "RowTextAlignment";
                //case RadGridStringId.ConditionalFormattingPropertyGridTextAlignment: return "TextAlignment";

                case RadGridStringId.ColumnChooserFormCaption: return "Chọn cột";
                case RadGridStringId.ColumnChooserFormMessage: return "Kéo một tiêu đề cột từ \n Lưới đây để loại bỏ nó từ \n Xem hiện tại.";
                case RadGridStringId.GroupingPanelDefaultMessage: return "Kéo một cột vào đây để nhóm theo cột này.";
                case RadGridStringId.GroupingPanelHeader: return "Nhóm bằng:";
                case RadGridStringId.NoDataText: return "Không có dữ liệu hiện thị";
                case RadGridStringId.CompositeFilterFormErrorCaption: return "Lọc lỗi";
                //case RadGridStringId.CompositeFilterFormInvalidFilter: return "The composite filter descriptor is not valid.";

                case RadGridStringId.ExpressionMenuItem: return "Biểu thức";
                case RadGridStringId.ExpressionFormTitle: return "Xây dựng biểu thức";
                case RadGridStringId.ExpressionFormFunctions: return "Hàm";
                case RadGridStringId.ExpressionFormFunctionsText: return "Văn bản";
                case RadGridStringId.ExpressionFormFunctionsAggregate: return "Tổng hợp";
                case RadGridStringId.ExpressionFormFunctionsDateTime: return "Ngày giờ";
                case RadGridStringId.ExpressionFormFunctionsLogical: return "Logical";
                case RadGridStringId.ExpressionFormFunctionsMath: return "Toán học";
                case RadGridStringId.ExpressionFormFunctionsOther: return "Khác";
                case RadGridStringId.ExpressionFormOperators: return "Nhà khai thác";
                case RadGridStringId.ExpressionFormConstants: return "Hằng số";
                case RadGridStringId.ExpressionFormFields: return "Trường";
                case RadGridStringId.ExpressionFormDescription: return "Dẫn giải";
                case RadGridStringId.ExpressionFormResultPreview: return "Xem trước kết quả";
                case RadGridStringId.ExpressionFormTooltipPlus: return "Dấu cộng";
                case RadGridStringId.ExpressionFormTooltipMinus: return "Âm";
                case RadGridStringId.ExpressionFormTooltipMultiply: return "Nhiều";
                case RadGridStringId.ExpressionFormTooltipDivide: return "Đoạn";
                case RadGridStringId.ExpressionFormTooltipModulo: return "Mô đun";
                case RadGridStringId.ExpressionFormTooltipEqual: return "Bằngl";
                case RadGridStringId.ExpressionFormTooltipNotEqual: return "Không bằng";
                case RadGridStringId.ExpressionFormTooltipLess: return "Nhỏ hơn";
                case RadGridStringId.ExpressionFormTooltipLessOrEqual: return "Nhỏ hơn hoặc bằng";
                case RadGridStringId.ExpressionFormTooltipGreaterOrEqual: return "Lớn hơn hoặc bằng";
                case RadGridStringId.ExpressionFormTooltipGreater: return "Lớn";
                case RadGridStringId.ExpressionFormTooltipAnd: return "Logical \"Và\"";
                case RadGridStringId.ExpressionFormTooltipOr: return "Logical \"Hoặc\"";
                case RadGridStringId.ExpressionFormTooltipNot: return "Logical \"Không\"";
                case RadGridStringId.ExpressionFormAndButton: return string.Empty; //if empty, default button image is used
                case RadGridStringId.ExpressionFormOrButton: return string.Empty; //if empty, default button image is used
                case RadGridStringId.ExpressionFormNotButton: return string.Empty; //if empty, default button image is used
                case RadGridStringId.ExpressionFormOKButton: return "Đồng ý";
                case RadGridStringId.ExpressionFormCancelButton: return "Hủy bỏ";
            }

            return string.Empty;
        }
    }
}
