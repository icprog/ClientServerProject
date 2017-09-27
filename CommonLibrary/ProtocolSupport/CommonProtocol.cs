﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HslCommunication.BasicFramework;

namespace CommonLibrary
{


    /*****************************************************************************************
     * 
     *    说明：本界面规定了客户端服务器双方共同遵守的一些协议基础，主要包含了端口号，令牌，密钥
     *    
     *    注意：在进行二次开发的时候，必须修改下面的所有参数
     * 
     *****************************************************************************************/

        
    /// <summary>
    /// 客户端服务器共同遵守的配置信息
    /// </summary>
    public class CommonProtocol
    {
        static CommonProtocol()
        {
            /**************************************************************************
             * 
             *    时间：2017年6月29日 07:58:02
             *    说明：更改版本机制，每次提交新增修订版的版本号
             *    发行：发行版将采用主版本加次版本来发行
             * 
             **************************************************************************/
             
            /**************************************************************************
             * 
             *    说明：以下是大版本号的发布日期
             *    
             *    时间：2017年7月7日 14:11:35       版本号：1.1.0
             *    时间：2017年7月18日 15:10:18      版本号：1.2.0
             *    时间：2017年9月3日 13:27:52       版本号：1.3.0
             *    时间：2017年9月19日 22:06:27      版本号：1.4.0
             * 
             **************************************************************************/

            SoftBasic.FrameworkVersion = new SystemVersion("1.4.10");

        }



        /************************************************************************************************
         * 
         *    注意：您在准备二次开发时，应该重新生成一个自己的GUID码
         * 
         ************************************************************************************************/


        /// <summary>
        /// 用于整个网络服务交互的身份令牌，可有效的防止来自网络的攻击，其他系统的恶意的连接
        /// 重新生成令牌后就无法更改，否则不支持自动升级
        /// </summary>
        public static Guid KeyToken { get; set; } = new Guid("1275BB9A-14B2-4A96-9673-B0AF0463D474");



        /************************************************************************************************
         * 
         *    注意：此处的所有的网络端口应该重新指定，防止其他人的项目连接到你的程序上
         *          假设你们的多个项目服务器假设在一台电脑的情况，就绝对要替换下面的端口号
         * 
         ************************************************************************************************/
         

        /// <summary>
        /// 主网络端口，此处随机定义了一个数据
        /// </summary>
        public static int Port_Main_Net { get; } = 17652;
        /// <summary>
        /// 同步网络访问的端口，此处随机定义了一个数据
        /// </summary>
        public static int Port_Second_Net { get; } = 14568;
        /// <summary>
        /// 用于软件系统更新的端口，此处随机定义了一个数据
        /// </summary>
        public static int Port_Update_Net { get; } = 17538;
        /// <summary>
        /// 共享文件的端口号
        /// </summary>
        public static int Port_Share_File { get; } = 34261;
        /// <summary>
        /// 用于UDP传输的端口号
        /// </summary>
        public static int Port_Udp_Server { get; } = 32566;
        /// <summary>
        /// 文件管理的服务器端口
        /// </summary>
        public static int Port_Advanced_File_Server { get; } = 24672;



        /// <summary>
        /// 整个系统的加密解密密码
        /// </summary>
        public static string Security { get; } = "qwertyui";
    }

}
