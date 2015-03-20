﻿using QQWpfApplication1.module;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QQWpfApplication1.evt
{
    interface QQContext
    {
        
	/**
	 * <p>pushActor.</p>
	 *
	 * @param actor a {@link iqq.im.actor.HttpActor} object.
	 */
	public void pushActor(HttpActor actor);
	/**
	 * <p>fireNotify.</p>
	 *
	 * @param event a {@link iqq.im.event.QQNotifyEvent} object.
	 */
	public void fireNotify(QQNotifyEvent evt);
	/**
	 * <p>getModule.</p>
	 *
	 * @param type a {@link iqq.im.core.QQModule.Type} object.
	 * @param <T> a T object.
	 * @return a T object.
	 */
    public AbstractModule getModule(AbstractModule.Type type);
	/**
	 * <p>getSerivce.</p>
	 *
	 * @param type a {@link iqq.im.core.QQService.Type} object.
	 * @param <T> a T object.
	 * @return a T object.
	 */
	public ApacheHttpService getSerivce();
	/**
	 * <p>getAccount.</p>
	 *
	 * @return a {@link iqq.im.bean.QQAccount} object.
	 */
	public QQUser getAccount();
	/**
	 * <p>getSession.</p>
	 *
	 * @return a {@link iqq.im.core.QQSession} object.
	 */
	public QQSession getSession();
	/**
	 * <p>getStore.</p>
	 *
	 * @return a {@link iqq.im.core.QQStore} object.
	 */
	public QQStore   getStore();

    }
}
