﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QQWpfApplication1.bean
{
    public abstract class ContentItem
    {
        public abstract Type getType();
	/**
	 * <p>toJson.</p>
	 *
	 * @throws iqq.im.QQException if any.
	 * @return a {@link java.lang.Object} object.
	 */
        public abstract Object toJson();
	/**
	 * <p>fromJson.</p>
	 *
	 * @param text a {@link java.lang.String} object.
	 * @throws iqq.im.QQException if any.
	 */
        public abstract void fromJson(String text);

	public enum Type {
		/**字体*/
		FONT,
		/** 文字*/
		TEXT,
		/**表情*/
		FACE,
		/**离线图片*/
		OFFPIC,
		/**群图片*/
		CFACE,
	}

    }
}
