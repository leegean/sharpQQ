﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QQWpfApplication1.bean
{
    class QQGroup
    {
        
	private long gid;	//真实的群号
	private long gin;	//变换后的群号
	private long code;
	private int clazz;
	private int flag;
	private int level;
	private int mask;
	private String name;
	private String memo;
	private String fingermemo;
	private DateTime createTime;
	private  Bitmap face; // 头像

	private List<QQGroupMember> members = new List<QQGroupMember>();


	/**
	 * <p>Getter for the field <code>code</code>.</p>
	 *
	 * @return the code
	 */
	public long getCode() {
		return code;
	}

	/**
	 * <p>Setter for the field <code>code</code>.</p>
	 *
	 * @param code
	 *            the code to set
	 */
	public void setCode(long code) {
		this.code = code;
	}

	/**
	 * <p>Getter for the field <code>clazz</code>.</p>
	 *
	 * @return the clazz
	 */
	public int getClazz() {
		return clazz;
	}

	/**
	 * <p>Setter for the field <code>clazz</code>.</p>
	 *
	 * @param clazz
	 *            the clazz to set
	 */
	public void setClazz(int clazz) {
		this.clazz = clazz;
	}

	/**
	 * <p>Getter for the field <code>flag</code>.</p>
	 *
	 * @return the flag
	 */
	public int getFlag() {
		return flag;
	}

	/**
	 * <p>Setter for the field <code>flag</code>.</p>
	 *
	 * @param flag
	 *            the flag to set
	 */
	public void setFlag(int flag) {
		this.flag = flag;
	}

	/**
	 * <p>Getter for the field <code>level</code>.</p>
	 *
	 * @return the level
	 */
	public int getLevel() {
		return level;
	}

	/**
	 * <p>Setter for the field <code>level</code>.</p>
	 *
	 * @param level
	 *            the level to set
	 */
	public void setLevel(int level) {
		this.level = level;
	}

	/**
	 * <p>Getter for the field <code>name</code>.</p>
	 *
	 * @return the name
	 */
	public String getName() {
		return name;
	}

	/**
	 * <p>Setter for the field <code>name</code>.</p>
	 *
	 * @param name
	 *            the name to set
	 */
	public void setName(String name) {
		this.name = name;
	}

	/**
	 * <p>Getter for the field <code>fingermemo</code>.</p>
	 *
	 * @return the fingermemo
	 */
	public String getFingermemo() {
		return fingermemo;
	}

	/**
	 * <p>Setter for the field <code>fingermemo</code>.</p>
	 *
	 * @param fingermemo
	 *            the fingermemo to set
	 */
	public void setFingermemo(String fingermemo) {
		this.fingermemo = fingermemo;
	}

	/**
	 * <p>Getter for the field <code>createTime</code>.</p>
	 *
	 * @return the createTime
	 */
	public DateTime getCreateTime() {
		return createTime;
	}

	/**
	 * <p>Setter for the field <code>createTime</code>.</p>
	 *
	 * @param createTime
	 *            the createTime to set
	 */
	public void setCreateTime(DateTime createTime) {
		this.createTime = createTime;
	}

	/**
	 * <p>Getter for the field <code>face</code>.</p>
	 *
	 * @return the face
	 */
	public Bitmap getFace() {
		return face;
	}

	/**
	 * <p>Setter for the field <code>face</code>.</p>
	 *
	 * @param face
	 *            the face to set
	 */
	public void setFace(Bitmap face) {
		this.face = face;
	}

	/**
	 * <p>Getter for the field <code>members</code>.</p>
	 *
	 * @return the members
	 */
	public List<QQGroupMember> getMembers() {
		return members;
	}

	/**
	 * <p>Setter for the field <code>members</code>.</p>
	 *
	 * @param members
	 *            the members to set
	 */
	public void setMembers(List<QQGroupMember> members) {
		this.members = members;
	}
	
	/**
	 * <p>Getter for the field <code>memo</code>.</p>
	 *
	 * @return the memo
	 */
	public String getMemo() {
		return memo;
	}

	/**
	 * <p>Setter for the field <code>memo</code>.</p>
	 *
	 * @param memo the memo to set
	 */
	public void setMemo(String memo) {
		this.memo = memo;
	}
	
	/**
	 * <p>getMemberByUin.</p>
	 *
	 * @param uin a long.
	 * @return a {@link iqq.im.bean.QQGroupMember} object.
	 */
	public QQGroupMember getMemberByUin(long uin){
		foreach(QQGroupMember mem in members){
			if(mem.getUin() == uin){
				return mem;
			}
		}
		return null;
	}

	/**
	 * <p>Getter for the field <code>mask</code>.</p>
	 *
	 * @return a int.
	 */
	public int getMask() {
		return mask;
	}

	/**
	 * <p>Setter for the field <code>mask</code>.</p>
	 *
	 * @param mask a int.
	 */
	public void setMask(int mask) {
		this.mask = mask;
	}

	/** {@inheritDoc} */
	public int hashCode() {
		return (int) this.getCode();
	}
	
	/** {@inheritDoc} */
	public Boolean equals(Object obj) {
		if (obj == null) {
			return false;
		}
		if (this == obj) {
			return true;
		}

		if (obj is QQGroup) {
			QQGroup g = (QQGroup) obj;
			if (g.getCode() == this.getCode()) {
				return true;
			}
		}
		return false;
	}
	
	/**
	 * <p>Getter for the field <code>gid</code>.</p>
	 *
	 * @return the gid
	 */
	public long getGid() {
		return gid;
	}

	/**
	 * <p>Setter for the field <code>gid</code>.</p>
	 *
	 * @param gid the gid to set
	 */
	public void setGid(long gid) {
		this.gid = gid;
	}
	

	/**
	 * <p>Getter for the field <code>gin</code>.</p>
	 *
	 * @return the gin
	 */
	public long getGin() {
		return gin;
	}

	/**
	 * <p>Setter for the field <code>gin</code>.</p>
	 *
	 * @param gin the gin to set
	 */
	public void setGin(long gin) {
		this.gin = gin;
	}
	
	

	/* (non-Javadoc)
	 * @see java.lang.Object#toString()
	 */
	/** {@inheritDoc} */
	public String toString() {
		return "QQGroup [gid=" + gid + ", code=" + code + ", name=" + name + "]";
	}



    }
}
