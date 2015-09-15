#<font color=purple><b>mDCM</b></font>

<font face="Microsoft YaHei"><b>mDCM, the former version of fo-dicom. <br>
Building my own respository for mDCM is just to testing and to learning well about fo-dicom by comparing mDCM wth fo-dicom.<br>
<i><font color=blue>zssure@163.com</font></i>
</b></font><br>

#<font color=purple><b>User Information</b></font>
<font face="Microsoft YaHei">
DICOM3.0标准中关于<b><font color=red>UserInformation</font></b>的介绍在<b>第8部分的附录D</b>([DICOM3.0 PS8 附录D](http://medical.nema.org/medical/dicom/current/output/html/part08.html#chapter_D)),标准指出<u>UserInformation(0x50)</u>项内容可扩展范围为<u>**0x51H-0XFFH**</u>,对于常见的<u>**0x51H-0x59H**</u>的扩展,在<font color=red>**DICOM3.0标准第7部分附录D**</font>中给出,具体参见[DICOM3.0 PS7 附录D](http://medical.nema.org/medical/dicom/current/output/html/part07.html#sect_D.3.3.7).<br><br>
之前mDCM版本中忽略了**UserInformation**中的**Sub-Item**,即**UserIdentity(0x58H)**,所以参照**dcm4che**工具包中的代码，对mDCM进行了扩展.主要修改如下:<br><br>
<font color=purple><b>
1. Dicom的Network目录下添加UserIdentity类,用于表示UserIdentity Sub-Item(0x58H)<br>
2. 扩展PDU.cs类,添加WriteAddingUserIdentity函数,便于向socket流数据体中添加UserIdentity子项目<br>
3. 扩展DicomNetworkBase.cs类,添加protected void SendAssociateRequest(DcmAssociate associate, UserIdentity userIdentity)<br>
4. 修改CStoreClient的OnConnected函数,添加写入UserIdentity子项目的判别分支<br>

</font></b>

【注】：详情可参照本人CSDN博客专栏[DICOM医学图像处理](http://blog.csdn.net/column/details/dicom.html)
</font>

<br>
<font color=blue><b>zssure@163.com</b></font>