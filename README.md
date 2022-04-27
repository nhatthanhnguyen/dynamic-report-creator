# Dynamic report creator
## Mô tả
Đồ án này là một web application được quản lý bằng Visual Studio 2019, toàn bộ source code backend được viết bằng ngôn ngữ C# với sự hỗ trợ của DevExpress 19.2 - một công cụ cực kỳ hữu dụng cho các lập trình viên .NET.

Web application này hỗ trợ người dùng phổ thông khi muốn tạo một báo cáo từ cơ sở dữ liệu bằng cách chọn các thông tin mà mình muốn hiển thị và tiêu đề báo cáo theo yêu cầu của người dùng.

Đi cùng với sự giúp đỡ của Visual Studio 2019 và DevExpress 19.2 chính là một trình quản lý database được sử dụng rộng rãi trong khi học ở các trường đại học, Microsft SQL Server 2014.

Giảng viên: Huỳnh Trung Trụ

## Kết quả đạt được

Khi kết thúc báo cáo đồ án, con số nhận được khá ấn tượng, 9.5.

## Các chức năng của đồ án

- Cho phép người dùng chọn server instance, database để vào truy vấn.
- Khi vào database sẽ có 2 lựa chọn là: To query builder và To custom query
  - To query builder: đi đến trình tạo truy vấn (không gian trống bên dưới 2 thông tin nhập tên báo cáo và kiểu in) bằng cách kéo thả bảng, chọn các trường, các điều kiện, tạo điều kiện,... để tạo nên câu truy vấn trước khi tạo báo cáo. Để tạo báo cáo, người dùng ấn nút Save trên query builder , trước đó người dùng cũng phải hoàn thành việc nhập tên báo cáo để trình tạo báo cáo có thể chạy được, nếu không sẽ đứng yên tại trang đó và không đi tiếp nữa.
  - To custom query: đi đến trình tạo truy vấn bằng cách người dùng tự nhập truy vấn, người dùng có thể chọn bảng ở query builder (đã được custom bằng cách xóa nút Save) để xem tên các bảng, các cột và mối liên hệ giữa các bảng đó, giúp cho việc viết query. Trong trang này, truy vấn phải được viết vào khung text ở ngay bên dưới dòng 'YOUR QUERY COMMAND', và tạo báo cáo bằng cách nhấn print report.
- Ngay sau khi người dùng chọn in báo cáo thì sẽ xuất hiện một trang cho phép người dùng nhìn thấy báo cáo được tạo. Trên thanh công cụ của trình xem báo cáo có các chức năng như phóng to, thu nhỏ, xuất báo cáo dưới dạng các file, in báo cáo, v.v..

## Hạn chế của đồ án

Chưa thực sự là một web application tạo báo cáo động. Vì còn thiếu chức năng quan trọng nhất, đó chính là tính tổng khi người dùng muốn tính toàn bộ dữ liệu đã được in ra trên báo cáo. Ví dụ:

|Vật tư|Số lượng|
|------|--------:|
|Sắt| 5000|
|Thép|4000|

Người báo cáo muốn tính tổng số lượng của tất cả vật tư thì web application này chưa thể tạo ra được.

***Fact***: Các bạn tham gia báo cáo đều **không** làm được chức năng này. Ngoài ra, query builder có một lỗi về group by, khi mình phát hiện thì cũng đã trễ, không thể khắc phục kịp trước khi nộp đồ án cho thầy (nhưng về cơ bản là không khắc phục được vì đó là chức năng của người tạo DevExpress phát triển). Và có một công cụ có thể đảm bảo được mọi yêu cầu của thầy, mình đã tìm ra trước 1 tuần, nhưng không dám đưa vào vì nó hỗ trợ toàn bộ từ A-Z, như thế không khác gì hack game :))

## Một số hình ảnh của đồ án

![image](https://user-images.githubusercontent.com/73063813/165458106-2691f105-e253-4271-8d6e-86a7f8aee19a.png)

Màn hình chính của đồ án

![image](https://user-images.githubusercontent.com/73063813/165458176-f0042833-037c-480d-95b0-e3d6a709521b.png)

Màn hình chọn cơ sở dữ liệu để tạo báo cáo

![image](https://user-images.githubusercontent.com/73063813/165458330-8bbb697a-169d-473c-b9fd-04926ecdd1dc.png)

Màn hình kéo thả table, điền tên báo cáo và chọn kiểu in

![image](https://user-images.githubusercontent.com/73063813/165458534-d9c5b490-3d5f-49ea-b697-9512c4d1f148.png)

Một ví dụ đơn giản

![image](https://user-images.githubusercontent.com/73063813/165458709-df0bddd9-5f92-4b7a-bda2-e56e5adb9c09.png)

Báo cáo được tạo ngay sau khi ấn Save ở trên query builder

![image](https://user-images.githubusercontent.com/73063813/165461325-222bca46-a2dc-4867-9eaf-b7df5b296957.png)

Một ví dụ khi ta chọn To custom query ở trang chọn database

