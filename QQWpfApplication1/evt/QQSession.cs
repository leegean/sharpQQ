﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QQWpfApplication1.action
{
    public class QQSession
    {

        private long clientId;
        private String sessionId;
        private String vfwebqq;
        private String ptwebqq;
        private String loginSig;
        private String cfaceKey;	// 上传群图片时需要
        private String cfaceSig;	// 上传群图片时需要
        private String emailAuthKey;// 邮箱登录认证
        private int index;			// 禁用群时需要
        private int port;			// 禁用群时需要
        private int pollErrorCnt;
        private volatile State state;

        int exectime;
        private long servertime;
        private String nonce;
        private String pubkey;
        private long rsakv;
        private String su;
        private String sp;

        private String qmLoginSig;
        public enum State
        {
            OFFLINE,
            ONLINE,
            KICKED,
            LOGINING,
            ERROR
        }

        /**
         * <p>Getter for the field <code>clientId</code>.</p>
         *
         * @return a long.
         */
        public long getClientId()
        {
            return clientId;
        }

        /**
         * <p>Setter for the field <code>clientId</code>.</p>
         *
         * @param clientId a long.
         */
        public void setClientId(long clientId)
        {
            this.clientId = clientId;
        }

        /**
         * <p>Getter for the field <code>sessionId</code>.</p>
         *
         * @return a {@link java.lang.String} object.
         */
        public String getSessionId()
        {
            return sessionId;
        }

        /**
         * <p>Setter for the field <code>sessionId</code>.</p>
         *
         * @param sessionId a {@link java.lang.String} object.
         */
        public void setSessionId(String sessionId)
        {
            this.sessionId = sessionId;
        }

        /**
         * <p>Getter for the field <code>vfwebqq</code>.</p>
         *
         * @return a {@link java.lang.String} object.
         */
        public String getVfwebqq()
        {
            return vfwebqq;
        }

        /**
         * <p>Setter for the field <code>vfwebqq</code>.</p>
         *
         * @param vfwebqq a {@link java.lang.String} object.
         */
        public void setVfwebqq(String vfwebqq)
        {
            this.vfwebqq = vfwebqq;
        }

        /**
         * <p>Getter for the field <code>pollErrorCnt</code>.</p>
         *
         * @return a int.
         */
        public int getPollErrorCnt()
        {
            return pollErrorCnt;
        }

        /**
         * <p>Setter for the field <code>pollErrorCnt</code>.</p>
         *
         * @param pollErrorCnt a int.
         */
        public void setPollErrorCnt(int pollErrorCnt)
        {
            this.pollErrorCnt = pollErrorCnt;
        }

        /**
         * <p>Getter for the field <code>state</code>.</p>
         *
         * @return a {@link iqq.im.core.QQSession.State} object.
         */
        public State getState()
        {
            return state;
        }

        /**
         * <p>Setter for the field <code>state</code>.</p>
         *
         * @param state a {@link iqq.im.core.QQSession.State} object.
         */
        public void setState(State state)
        {
            this.state = state;
        }

        /**
         * <p>Getter for the field <code>cfaceKey</code>.</p>
         *
         * @return the cfaceKey
         */
        public String getCfaceKey()
        {
            return cfaceKey;
        }

        /**
         * <p>Setter for the field <code>cfaceKey</code>.</p>
         *
         * @param cfaceKey the cfaceKey to set
         */
        public void setCfaceKey(String cfaceKey)
        {
            this.cfaceKey = cfaceKey;
        }

        /**
         * <p>Getter for the field <code>cfaceSig</code>.</p>
         *
         * @return the cfaceSig
         */
        public String getCfaceSig()
        {
            return cfaceSig;
        }

        /**
         * <p>Setter for the field <code>cfaceSig</code>.</p>
         *
         * @param cfaceSig the cfaceSig to set
         */
        public void setCfaceSig(String cfaceSig)
        {
            this.cfaceSig = cfaceSig;
        }

        /**
         * <p>Getter for the field <code>index</code>.</p>
         *
         * @return a int.
         */
        public int getIndex()
        {
            return index;
        }

        /**
         * <p>Setter for the field <code>index</code>.</p>
         *
         * @param index a int.
         */
        public void setIndex(int index)
        {
            this.index = index;
        }

        /**
         * <p>Getter for the field <code>port</code>.</p>
         *
         * @return a int.
         */
        public int getPort()
        {
            return port;
        }

        /**
         * <p>Setter for the field <code>port</code>.</p>
         *
         * @param port a int.
         */
        public void setPort(int port)
        {
            this.port = port;
        }

        /**
         * <p>Getter for the field <code>ptwebqq</code>.</p>
         *
         * @return a {@link java.lang.String} object.
         */
        public String getPtwebqq()
        {
            return ptwebqq;
        }

        /**
         * <p>Setter for the field <code>ptwebqq</code>.</p>
         *
         * @param ptwebqq a {@link java.lang.String} object.
         */
        public void setPtwebqq(String ptwebqq)
        {
            this.ptwebqq = ptwebqq;
        }

        /**
         * <p>Getter for the field <code>loginSig</code>.</p>
         *
         * @return a {@link java.lang.String} object.
         */
        public String getLoginSig()
        {
            return loginSig;
        }

        /**
         * <p>Setter for the field <code>loginSig</code>.</p>
         *
         * @param loginSig a {@link java.lang.String} object.
         */
        public void setLoginSig(String loginSig)
        {
            this.loginSig = loginSig;
        }

        /**
         * <p>Getter for the field <code>emailAuthKey</code>.</p>
         *
         * @return a {@link java.lang.String} object.
         */
        public String getEmailAuthKey()
        {
            return emailAuthKey;
        }

        /**
         * <p>Setter for the field <code>emailAuthKey</code>.</p>
         *
         * @param emailAuthKey a {@link java.lang.String} object.
         */
        public void setEmailAuthKey(String emailAuthKey)
        {
            this.emailAuthKey = emailAuthKey;
        }

        /**
         * @return the qmLoginSig
         */
        public String getQmLoginSig()
        {
            return qmLoginSig;
        }

        /**
         * @param qmLoginSig the qmLoginSig to set
         */
        public void setQmLoginSig(String qmLoginSig)
        {
            this.qmLoginSig = qmLoginSig;
        }

        public long getServertime()
        {
            return servertime;
        }

        public void setServertime(long servertime)
        {
            this.servertime = servertime;
        }

        public String getNonce()
        {
            return nonce;
        }

        public void setNonce(String nonce)
        {
            this.nonce = nonce;
        }

        public String getPubkey()
        {
            return pubkey;
        }

        public void setPubkey(String pubkey)
        {
            this.pubkey = pubkey;
        }

        public long getRsakv()
        {
            return rsakv;
        }

        public void setRsakv(long rsakv)
        {
            this.rsakv = rsakv;
        }

        public String getSu()
        {
            return su;
        }

        public void setSu(String su)
        {
            this.su = su;
        }

        public String getSp()
        {
            return sp;
        }

        public void setSp(String sp)
        {
            this.sp = sp;
        }

        public int getExectime()
        {
            return exectime;
        }

        public void setExectime(int exectime)
        {
            this.exectime = exectime;
        }

    }
}
