# mDCM

<font face="Microsoft YaHei" color=blue>mDCM,the former version of fo-dicom. Building my own respository for mDCM is just to testing and to learning well about fo-dicom by comparing mDCM wth fo-dicom.</font><br>

#User Information

DICOM3.0标准中关于UserInformation的介绍在第8部分的附录D([DICOM3.0 PS8 附录D](http://medical.nema.org/medical/dicom/current/output/html/part08.html#chapter_D)),标准指出UserInformation(0x50)项内容可扩展范围为0x51H-0XFFH,对于常见的0x51H-0x59H的扩展,在DICOM3.0标准第7部分附录D中给出,具体参见[DICOM3.0 PS7 附录D](http://medical.nema.org/medical/dicom/current/output/html/part07.html#sect_D.3.3.7).<br>
之前mDCM版本中忽略了UserInformation中的Sub-Item,即UserIdentity(0x58H),所以参照dcm4che2工具包中的代码，对mDCM进行了扩展.主要修改如下:<br>
1.Dicom的Network目录下添加UserIdentity类,用于表示UserIdentity Sub-Item(0x58H)<br>
2.扩展PDU.CS类,添加WriteAddingUserIdentity函数,便于向socket流数据体中添加UserIdentity子项目<br>
3.扩展DicomNetworkBase.cs类,添加protected void SendAssociateRequest(DcmAssociate associate, UserIdentity userIdentity)<br>
4.修改CStoreClient的OnConnected函数,添加写入UserIdentity子项目的判别分支<br>
【注】：详情可参照本人CSDN博客专栏[DICOM医学图像处理](http://blog.csdn.net/column/details/dicom.html)
