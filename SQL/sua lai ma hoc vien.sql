

----đổi lại ví trí của lớp và năm                 ------------(1)--------
--declare @mahovien_dt nvarchar(50)
--declare @id int
--declare @check nvarchar(1)
--DECLARE  p3 CURSOR scroll
--for 
--select mahocvien,id from DT_LienTuc_HocVien 
--where NgayBatDau  >= '2014/08/19'
--and HinhThucHoc = N'Theo lớp'
--and MaHocVien <> ''

--open p3
--fetch first from p3 into @mahovien_dt,@id
--while @@FETCH_STATUS = 0
--BEGIN
--                  -------------------(1.1)-----------------
--		--update DT_LienTuc_HocVien
--		--set 
--		--MaHocVien = substring(MaHocVien, 1,len(MaHocVien) - 9) + SUBSTRING(MaHocVien,len(MaHocVien)-5,2) +'-'+ SUBSTRING(MaHocVien, len(MaHocVien)-8,2) + '-B24'
--		--where id = @id
		  
--		   --------------------------(1.2)-----------------
--		  UPDATE dbo.DT_LienTuc_HocVien
--		  SET MaHocVien = '0' + MaHocVien
--		  WHERE id = @id

--	fetch next from p3 into @mahovien_dt,@id
	
--end
--close p3
--deallocate p3
--GO


---- đổi lại mã kèm cặp theo chuẩn có số 0 đứng trước.  ---------------(2)-------------

--DECLARE @mahocvien_p4 NVARCHAR(50)
--DECLARE @id_p4 INT
--DECLARE p4 CURSOR SCROLL
--FOR
--select mahocvien,id from DT_LienTuc_HocVien 
--where NgayDangKi  >= '2014/08/19'
--and HinhThucHoc = N'Kèm cặp'
--and MaHocVien <> ''
--AND SUBSTRING(MaHocVien,1,2) <> 'KC'

--OPEN p4
--FETCH FIRST FROM p4 INTO @mahocvien_p4, @id_p4
--WHILE @@FETCH_STATUS = 0
--BEGIN
--	--Code here
--	IF(SUBSTRING(@mahocvien_p4,2,1) = '-')
--	BEGIN
--		UPDATE dbo.DT_LienTuc_HocVien
--		SET MaHocVien = '00'+ @mahocvien_p4
--		WHERE id = @id_p4
--    END
--	ELSE IF(SUBSTRING(@mahocvien_p4,3,1) = '-')
--	BEGIN
--		UPDATE dbo.DT_LienTuc_HocVien
--		SET MaHocVien = '0' + @mahocvien_p4
--		WHERE id = @id_p4
--    END 
--FETCH NEXT FROM p4 INTO @mahocvien_p4,@id_p4
--END 
--CLOSE p4
--DEALLOCATE p4

---- đổi lại thứ tự với những mã nào có stt 4 số xếp dưới cùng   ----------------(3)-------------

--DECLARE @mahocvien_p1 NVARCHAR(50)
--DECLARE @id_p1 INT
--DECLARE p1 CURSOR SCROLL
--FOR
--select mahocvien,id from DT_LienTuc_HocVien 
--where NgayDangKi  >= '2014/08/19'
--and HinhThucHoc = N'Kèm cặp'
--and MaHocVien <> ''
--AND SUBSTRING(MaHocVien,1,2) = 'KC'

--OPEN p1
--FETCH FIRST FROM p1 INTO @mahocvien_p1, @id_p1
--WHILE @@FETCH_STATUS = 0
--BEGIN
--	--Code here
	
--		UPDATE dbo.DT_LienTuc_HocVien
--		SET MaHocVien = SUBSTRING(@mahocvien_p1, LEN(@mahocvien_p1) - 3,4) + '-' + SUBSTRING(@mahocvien_p1,1,LEN(@mahocvien_p1)-5)
--		WHERE id = @id_p1
--FETCH NEXT FROM p1 INTO @mahocvien_p1,@id_p1
--END 
--CLOSE p1
--DEALLOCATE p1

-- -- CHuyển B24 ở giữa về cuối ---------------------------(4)------------------

--DECLARE @mahocvien_p1 NVARCHAR(50)
--DECLARE @id_p1 INT
--DECLARE p1 CURSOR SCROLL
--FOR
--select mahocvien,id from DT_LienTuc_HocVien 
--where NgayDangKi  >= '2014/08/19'
--and HinhThucHoc = N'Kèm cặp'
--and MaHocVien <> ''
--AND SUBSTRING(MaHocVien,6,2) = 'KC'

--OPEN p1
--FETCH FIRST FROM p1 INTO @mahocvien_p1, @id_p1
--WHILE @@FETCH_STATUS = 0
--BEGIN
--	--Code here
	
--		UPDATE dbo.DT_LienTuc_HocVien
--		SET MaHocVien = SUBSTRING(@mahocvien_p1,1, LEN(@mahocvien_p1) - 7) + SUBSTRING(@mahocvien_p1,LEN(@mahocvien_p1)-2,3) + SUBSTRING(@mahocvien_p1,LEN(@mahocvien_p1)-6,4)
--		WHERE id = @id_p1
--FETCH NEXT FROM p1 INTO @mahocvien_p1,@id_p1
--END 
--CLOSE p1
--DEALLOCATE p1

---- thêm số 0 vào những mã nào có stt là 3 số -------------------(5)----------------
--DECLARE @mahocvien_p1 NVARCHAR(50)
--DECLARE @id_p1 INT
--DECLARE p1 CURSOR SCROLL
--FOR
--select mahocvien,id from DT_LienTuc_HocVien 
--where NgayDangKi  >= '2014/08/19'
--and HinhThucHoc = N'Kèm cặp'
--and MaHocVien <> ''
--AND SUBSTRING(MaHocVien,5,2) = 'KC'

--OPEN p1
--FETCH FIRST FROM p1 INTO @mahocvien_p1, @id_p1
--WHILE @@FETCH_STATUS = 0
--BEGIN
--	--Code here
	
--		UPDATE dbo.DT_LienTuc_HocVien
--		SET MaHocVien = '0' + MaHocVien
--		WHERE id = @id_p1
--FETCH NEXT FROM p1 INTO @mahocvien_p1,@id_p1
--END 
--CLOSE p1
--DEALLOCATE p1

------ Sửa lại mã lớp                   --------------------(6)-------------------
--declare @malop_dt nvarchar(50)
--DECLARE  p5 CURSOR scroll
--for 
--select MaLop from DT_LienTuc_LopHoc
--where NgayBatDau  >= '2014/08/19'

--open p5
--fetch first from p5 into @malop_dt
--while @@FETCH_STATUS = 0
--begin
---------------------------------------------------(6.1)--------------------
--		--update dbo.DT_LienTuc_LopHoc
--		--set 
--		--MaLop = substring(MaLop, 1,len(MaLop) - 6) + SUBSTRING(MaLop,len(MaLop)-2,3) +'-'+ SUBSTRING(MaLop, len(MaLop)-4,2)
--		--where MaLop = @malop_dt

--		--/*******Các mã có B24 ở giữa ví dụ: 'TL-BM-B24-CC-14-14' ******/-------(6.2)-------
--  		--IF(SUBSTRING(@malop_dt,6,4) = '-B24')
--		--BEGIN
--		--	update dbo.DT_LienTuc_LopHoc
--		--	set 
--		--	MaLop = substring(MaLop, 1,5) + SUBSTRING(MaLop,11,LEN(MaLop) - 10)
--		--	where MaLop = @malop_dt
--		--END

--		--/********Thêm B24 vao sau mã****/            ------------(6.3)------------

 
--		--	update dbo.DT_LienTuc_LopHoc
--		--	set 
--		--	MaLop = MaLop + '-B24'
--		--	where MaLop = @malop_dt

--	fetch next from p5 into @malop_dt
--end
--close p5
--deallocate p5

/*đổi lại stt của mã học viên thành 4 số*/


