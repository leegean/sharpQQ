﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QQWpfApplication1.action
{
    class QQConstants
    {
        
	/** Constant <code>APPID="1003903"</code> */
	public static readonly String APPID = "1003903";
	public static readonly String JSVER = "10114";
	/** Constant <code>REFFER="http://d.web2.qq.com/proxy.html?v=20110"{trunked}</code> */
	public static readonly String REFFER = "http://d.web2.qq.com/proxy.html?v=20140612002&callback=1&id=3";
	/** Constant <code>USER_AGENT="IQQ Client/0.1 dev"</code> */
	public static readonly String USER_AGENT = "IQQ Client/0.1 dev";
	/** Constant <code>URL_CHECK_VERIFY="https://ssl.ptlogin2.qq.com/check?uin={"{trunked}</code> */
	public static readonly String URL_CHECK_VERIFY = "https://ssl.ptlogin2.qq.com/check?pt_tea=1&uin={0}&appid="+APPID+"&js_ver=10114&js_type=0&login_sig={1}&u1=http%3A%2F%2Fweb2.qq.com%2Floginproxy.html&r={2}";
	/** Constant <code>URL_GET_CAPTCHA="http://captcha.qq.com/getimage"</code> */
	public static readonly String URL_GET_CAPTCHA = "http://captcha.qq.com/getimage";
	/** Constant <code>REGXP_CHECK_VERIFY="ptui_checkVC\\('(.*?)','(.*?)','(.*?)'("{trunked}</code> */
	public static readonly String REGXP_CHECK_VERIFY = "ptui_checkVC\\('(.*?)','(.*?)','(.*?)'(,\\s*'(.*?)')?\\)";
	/** Constant <code>REGXP_LOGIN="ptuiCB\\('(\\d+)','(\\d+)','(.*?)','(\\"{trunked}</code> */
	public static readonly String REGXP_LOGIN = "ptuiCB\\('(\\d+)','(\\d+)','(.*?)','(\\d+)','(.*?)', '(.*?)'\\)";
	/** Constant <code>REGXP_JSON_SINGLE_RESULT="\\{([\\s\\S]*)\\}"</code> */
	public static readonly String REGXP_JSON_SINGLE_RESULT = "\\{([\\s\\S]*)\\}";
	/** Constant <code>URL_UI_LOGIN="https://ssl.ptlogin2.qq.com/login"</code> */
	public static readonly String URL_UI_LOGIN = "https://ssl.ptlogin2.qq.com/login";
	/** Constant <code>URL_CHANNEL_LOGIN="http://d.web2.qq.com/channel/login2"</code> */
	public static readonly String URL_CHANNEL_LOGIN = "http://d.web2.qq.com/channel/login2";
	/** Constant <code>URL_GET_FRIEND_INFO="http://s.web2.qq.com/api/get_friend_inf"{trunked}</code> */
	public static readonly String URL_GET_FRIEND_INFO = "http://s.web2.qq.com/api/get_friend_info2";
	/** Constant <code>URL_GET_STRANGER_INFO="http://s.web2.qq.com/api/get_stranger_i"{trunked}</code> */
	public static readonly String URL_GET_STRANGER_INFO = "http://s.web2.qq.com/api/get_stranger_info2";
	/** Constant <code>URL_GET_IMAGE="https://ssl.captcha.qq.com/getimage"</code> */
	public static readonly String URL_GET_IMAGE = "https://ssl.captcha.qq.com/getimage";
	/** Constant <code>URL_POLL_MSG="http://d.web2.qq.com/channel/poll2"</code> */
	public static readonly String URL_POLL_MSG = "http://d.web2.qq.com/channel/poll2";
	/** Constant <code>URL_GET_USER_CATEGORIES="http://s.web2.qq.com/api/get_user_frien"{trunked}</code> */
	public static readonly String URL_GET_USER_CATEGORIES = "http://s.web2.qq.com/api/get_user_friends2";
	/** Constant <code>URL_GET_USER_FACE="http://face10.qun.qq.com/cgi/svr/face/g"{trunked}</code> */
	public static readonly String URL_GET_USER_FACE = "http://face10.qun.qq.com/cgi/svr/face/getface";
	/** Constant <code>URL_GET_GROUP_NAME_LIST="http://s.web2.qq.com/api/get_group_name"{trunked}</code> */
	public static readonly String URL_GET_GROUP_NAME_LIST = "http://s.web2.qq.com/api/get_group_name_list_mask2";
	/** Constant <code>URL_GET_USER_ACCOUNT="http://s.web2.qq.com/api/get_friend_uin"{trunked}</code> */
	public static readonly String URL_GET_USER_ACCOUNT = "http://s.web2.qq.com/api/get_friend_uin2";
	/** Constant <code>URL_GET_USER_SIGN="http://s.web2.qq.com/api/get_single_lon"{trunked}</code> */
	public static readonly String URL_GET_USER_SIGN = "http://s.web2.qq.com/api/get_single_long_nick2";
	/** Constant <code>URL_GET_ONLINE_BUDDY_LIST="http://d.web2.qq.com/channel/get_online"{trunked}</code> */
	public static readonly String URL_GET_ONLINE_BUDDY_LIST = "http://d.web2.qq.com/channel/get_online_buddies2";
	/** Constant <code>URL_SEND_BUDDY_MSG="http://d.web2.qq.com/channel/send_buddy"{trunked}</code> */
	public static readonly String URL_SEND_BUDDY_MSG = "http://d.web2.qq.com/channel/send_buddy_msg2";
	/** Constant <code>URL_SEND_GROUP_MSG="http://d.web2.qq.com/channel/send_qun_m"{trunked}</code> */
	public static readonly String URL_SEND_GROUP_MSG = "http://d.web2.qq.com/channel/send_qun_msg2";
	/** Constant <code>URL_SEND_DISCUZ_MSG="http://d.web2.qq.com/channel/send_discu"{trunked}</code> */
	public static readonly String URL_SEND_DISCUZ_MSG = "http://d.web2.qq.com/channel/send_discu_msg2";
	/** Constant <code>URL_SEND_SESSION_MSG="http://d.web2.qq.com/channel/send_sess_"{trunked}</code> */
	public static readonly String URL_SEND_SESSION_MSG = "http://d.web2.qq.com/channel/send_sess_msg2";
	/** Constant <code>URL_UPLOAD_OFFLINE_PICTURE="http://weboffline.ftn.qq.com/ftn_access"{trunked}</code> */
	public static readonly String URL_UPLOAD_OFFLINE_PICTURE = "http://weboffline.ftn.qq.com/ftn_access/upload_offline_pic";
	/** Constant <code>URL_UPLOAD_CUSTOM_FACE="http://up.web2.qq.com/cgi-bin/cface_upl"{trunked}</code> */
	public static readonly String URL_UPLOAD_CUSTOM_FACE = "http://up.web2.qq.com/cgi-bin/cface_upload";
	/** Constant <code>URL_CUSTOM_FACE_SIG="http://d.web2.qq.com/channel/get_gface_"{trunked}</code> */
	public static readonly String URL_CUSTOM_FACE_SIG = "http://d.web2.qq.com/channel/get_gface_sig2";
	/** Constant <code>URL_LOGOUT="http://d.web2.qq.com/channel/logout2"</code> */
	public static readonly String URL_LOGOUT = "http://d.web2.qq.com/channel/logout2";
	/** Constant <code>URL_CHANGE_STATUS="http://d.web2.qq.com/channel/change_sta"{trunked}</code> */
	public static readonly String URL_CHANGE_STATUS = "http://d.web2.qq.com/channel/change_status2";
	/** Constant <code>URL_GET_GROUP_INFO_EXT="http://s.web2.qq.com/api/get_group_info"{trunked}</code> */
	public static readonly String URL_GET_GROUP_INFO_EXT = "http://s.web2.qq.com/api/get_group_info_ext2";
	/** Constant <code>URL_GROUP_MESSAGE_FILTER="http://cgi.web2.qq.com/keycgi/qqweb/uac"{trunked}</code> */
	public static readonly String URL_GROUP_MESSAGE_FILTER = "http://cgi.web2.qq.com/keycgi/qqweb/uac/messagefilter.do";
	/** Constant <code>URL_GET_DISCUZ_LIST="http://s.web2.qq.com/api/get_discus_lis"{trunked}</code> */
	public static readonly String URL_GET_DISCUZ_LIST = "http://s.web2.qq.com/api/get_discus_list";
	/** Constant <code>URL_GET_DISCUZ_INFO="http://d.web2.qq.com/channel/get_discu_"{trunked}</code> */
	public static readonly String URL_GET_DISCUZ_INFO = "http://d.web2.qq.com/channel/get_discu_info";
	/** Constant <code>URL_GET_RECENT_LIST="http://d.web2.qq.com/channel/get_recent"{trunked}</code> */
	public static readonly String URL_GET_RECENT_LIST = "http://d.web2.qq.com/channel/get_recent_list2";
	/** Constant <code>URL_SHAKE_WINDOW="http://d.web2.qq.com/channel/shake2"</code> */
	public static readonly String URL_SHAKE_WINDOW = "http://d.web2.qq.com/channel/shake2";
	/** Constant <code>URL_GET_OFFPIC="http://d.web2.qq.com/channel/get_offpic"{trunked}</code> */
	public static readonly String URL_GET_OFFPIC = "http://d.web2.qq.com/channel/get_offpic2";
	/** Constant <code>URL_GET_CFACE2="http://d.web2.qq.com/channel/get_cface2"</code> */
	public static readonly String URL_GET_CFACE2= "http://d.web2.qq.com/channel/get_cface2";
	/** Constant <code>URL_GET_GROUP_PIC="http://web.qq.com/cgi-bin/get_group_pic"</code> */
	public static readonly String URL_GET_GROUP_PIC = "http://web.qq.com/cgi-bin/get_group_pic";
	/** Constant <code>URL_GET_SESSION_MSG_SIG="http://d.web2.qq.com/channel/get_c2cmsg"{trunked}</code> */
	public static readonly String URL_GET_SESSION_MSG_SIG = "http://d.web2.qq.com/channel/get_c2cmsg_sig2";
	/** Constant <code>URL_SEND_INPUT_NOTIFY="http://d.web2.qq.com/channel/input_noti"{trunked}</code> */
	public static readonly String URL_SEND_INPUT_NOTIFY = "http://d.web2.qq.com/channel/input_notify2";
	/** Constant <code>URL_GET_USER_LEVEL="http://s.web2.qq.com/api/get_qq_level2"</code> */
	public static readonly String URL_GET_USER_LEVEL = "http://s.web2.qq.com/api/get_qq_level2";
	/** Constant <code>URL_GET_GROUP_MEMBER_STATUS="http://s.web2.qq.com/api/get_group_memb"{trunked}</code> */
	public static readonly String URL_GET_GROUP_MEMBER_STATUS = "http://s.web2.qq.com/api/get_group_member_stat2";
	/** Constant <code>URL_SERACH_USER_BY_UIN="http://s.web2.qq.com/api/search_qq_by_u"{trunked}</code> */
	public static readonly String URL_SERACH_USER_BY_UIN = "http://s.web2.qq.com/api/search_qq_by_uin2";
	/** Constant <code>URL_ADD_NO_VERIFY2="http://s.web2.qq.com/api/add_no_verify2"</code> */
	public static readonly String URL_ADD_NO_VERIFY2 = "http://s.web2.qq.com/api/add_no_verify2";
	/** Constant <code>URL_ADD_NEED_VERIFY2="http://s.web2.qq.com/api/add_need_verif"{trunked}</code> */
	public static readonly String URL_ADD_NEED_VERIFY2 = "http://s.web2.qq.com/api/add_need_verify2";
	/** Constant <code>URL_ADD_ANSWER_AND_ADD="http://s.web2.qq.com/api/answer_and_add"{trunked}</code> */
	public static readonly String URL_ADD_ANSWER_AND_ADD = "http://s.web2.qq.com/api/answer_and_add2";
	/** Constant <code>URL_LOGIN_PAGE="https://ui.ptlogin2.qq.com/cgi-bin/logi"{trunked}</code> */
	public static readonly String URL_LOGIN_PAGE = "https://ui.ptlogin2.qq.com/cgi-bin/login?daid=164&target=self&style=5&mibao_css=m_webqq&appid=1003903&enable_qlogin=0&no_verifyimg=1&s_url=http%3A%2F%2Fweb2.qq.com%2Floginproxy.html&f_url=loginerroralert&strong_login=1&login_state=10&t=20130723001";
	/** Constant <code>URL_SEARCH_GROUP_INFO="http://cgi.web2.qq.com/keycgi/qqweb/gro"{trunked}</code> */
	public static readonly String URL_SEARCH_GROUP_INFO = "http://cgi.web2.qq.com/keycgi/qqweb/group/search.do";
	/** Constant <code>REGXP_LOGIN_SIG="var g_login_sig=encodeURIComponent\\(\""{trunked}</code> */
	public static readonly String REGXP_LOGIN_SIG = "var g_login_sig=encodeURIComponent\\(\"(.*?)\"\\);";
	
	// Email
	/** Constant <code>URL_EMAIL_POLL="http://wp.mail.qq.com/poll"</code> */
	public static readonly String URL_EMAIL_POLL = "http://wp.mail.qq.com/poll";
	/** Constant <code>URL_PT4_AUTH="http://ptlogin2.qq.com/pt4_auth"</code> */
	public static readonly String URL_PT4_AUTH = "http://ptlogin2.qq.com/pt4_auth";
	/** Constant <code>URL_GET_WP_KEY="http://mail.qq.com/cgi-bin/getwpkey"</code> */
	public static readonly String URL_GET_WP_KEY = "http://mail.qq.com/cgi-bin/getwpkey";
	/** Constant <code>URL_LOGIN_EMAIL="http://mail.qq.com/cgi-bin/login?fun=pa"{trunked}</code> */
	public static readonly String URL_LOGIN_EMAIL = "http://mail.qq.com/cgi-bin/login?fun=passport&from=webqq";
	/** Constant <code>URL_MARK_EMAIL="http://mail.qq.com/cgi-bin/mail_mgr"</code> */
	public static readonly String URL_MARK_EMAIL = "http://mail.qq.com/cgi-bin/mail_mgr";
	/** Constant <code>REGXP_EMAIL_AUTH="ptui_auth_CB\\('(.*?)','(.*?)'\\)"</code> */
	public static readonly String REGXP_EMAIL_AUTH = "ptui_auth_CB\\('(.*?)','(.*?)'\\)";
	
//	拒绝加群String "http://d.web2.qq.com/channel/op_group_join_req?group_uin=848492696&req_uin=3904214993&msg=no%20come%20in&op_type=3&clientid=5172539&psessionid=8368046764001d636f6e6e7365727665725f77656271714031302e3133392e372e3136340000444d000004ec016e0400b720ba3b6d0000000a403970744e50566654646d0000002877cd573fa047d3efb277b2002f1e30e5b476e29a0b5ad29c76bdec6915b0fd49a3be5855bae9cdaf&t=1419232988201";
//同意加群		         http://d.web2.qq.com/channel/op_group_join_req?group_uin=848492696&req_uin=3904214993&msg=&op_type=2&clientid=5172539&psessionid=8368046764001d636f6e6e7365727665725f77656271714031302e3133392e372e3136340000444d000004ec016e0400b720ba3b6d0000000a403970744e50566654646d0000002877cd573fa047d3efb277b2002f1e30e5b476e29a0b5ad29c76bdec6915b0fd49a3be5855bae9cdaf&t=1419233377649
	
	
	/** Constant <code>MAX_POLL_ERR_CNT=10</code> */
	public static readonly int MAX_POLL_ERR_CNT = 10;
	/** Constant <code>MAX_RETRY_TIMES=5</code> */
	public static readonly int MAX_RETRY_TIMES = 5;
	/** Constant <code>HTTP_TIME_OUT=80000</code> */
	public static readonly int HTTP_TIME_OUT = 80000;
	
	public static readonly String URL_QM_LOGIN_SIG = "http://ui.ptlogin2.qq.com/cgi-bin/login?appid=715030901&daid=73&pt_no_auth=1&s_url=http%3A%2F%2Fqun.qq.com%2F";
	public static readonly String REGXP_QM_LOGIN_SIG = "login_sig:\"([^\"]*)\"";
	public static readonly String URL_QM_CHECK_VERIFY = "http://check.ptlogin2.qq.com/check";
	public static readonly String REGXP_QM_CHECK_VERIFY = "ptui_checkVC\\('([^']*)','([^']*)','([^']*)','([^']*)','([^']*)'\\);";
	public static readonly String URL_QM_GET_CAPTCHA = "http://captcha.qq.com/getimage?uin={0}&aid={1}&cap_cd=0&{2}";
	public static readonly String REGXP_QM_LOGIN = "ptuiCB\\('([^']*)','([^']*)','([^']*)','([^']*)','([^']*)', '([^']*)'\\);";
	public static readonly String URL_QM_UI_LOGIN = "http://ptlogin2.qq.com/login";
	public static readonly String QM_APPID = "715030901";
	public static readonly String QM_JS_VER = "10107";
	public static readonly String URL_QM_SEATCH_GROUP_MEMBERS = "http://qun.qq.com/cgi-bin/qun_mgr/search_group_members";
	public static readonly String URL_QM_SET_GROUP_CARD = "http://qun.qq.com/cgi-bin/qun_mgr/set_group_card";
	public static readonly String URL_QM_DELETE_GROUP_MEMBER = "http://qun.qq.com/cgi-bin/qun_mgr/delete_group_member";
	
	
	public static readonly String  WB_ENTRY = "mweibo";
	public static readonly String  WB_PRELOGIN = "http://login.sina.com.cn/sso/prelogin.php?checkpin=1&entry=" + WB_ENTRY;
	public static readonly String  WB_LOGIN = "http://passport.weibo.cn/sso/login";
	public static readonly String  WB_VERIFY_IMAGE = "http://passport.weibo.cn/captcha/image";
	public static readonly String WB_SEND_MSG = "http://m.weibo.cn/msgDeal/sendMsg?";
	public static readonly String WB_POLL_MSG = "http://m.weibo.cn/msg/messages?uid={0}&page={1}";
	

    }
}
