# Dynamic report creator
## Mô tả
Đồ án này là một web application được quản lý bằng Visual Studio 2019, toàn bộ source code backend được viết bằng ngôn ngữ C# với sự hỗ trợ của DevExpress 19.2 - một công cụ cực kỳ hữu dụng cho các lập trình viên .NET. 

Web application này hỗ trợ người dùng phổ thông khi muốn tạo một báo cáo từ cơ sở dữ liệu bằng cách chọn các thông tin mà mình muốn hiển thị và tiêu đề báo cáo theo yêu cầu của người dùng.

Đi cùng với sự giúp đỡ của Visual Studio 2019 và DevExpress 19.2 chính là một trình quản lý database được sử dụng rộng rãi trong khi học ở các trường đại học, Microsft SQL Server 2014.

## Kết quả đạt được

Khi kết thúc báo cáo đồ án, con số nhận được khá ấn tượng, 9.5.

## Hạn chế của đồ án

Chưa thực sự là một web application tạo báo cáo động. Vì còn thiếu chức năng quan trọng nhất, đó chính là tính tổng khi người dùng muốn tính toàn bộ dữ liệu đã được in ra trên báo cáo. Ví dụ:

|Vật tư|Số lượng|
|------|--------|
|Sắt| 5000|
|Thép|4000|

Người báo cáo muốn tính tổng số lượng của tất cả vật tư thì web application này chưa thể tạo ra được.

Fact: Các bạn tham gia báo cáo đều không làm được chức năng này.

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

Ấn biểu tượng Save để có thể tạo báo cáo
