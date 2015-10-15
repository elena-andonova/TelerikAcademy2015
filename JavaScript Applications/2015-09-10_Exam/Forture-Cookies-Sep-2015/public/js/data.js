var data = (function() {

  const USERNAME_STORAGE_KEY = 'username-key',
    AUTH_KEY_STORAGE_KEY = 'auth-key-key';

  function userLogin(user) {
    var primi = new Promise(function(resolve, reject) {
      var reqUser = {
        username: user.username,
        passHash: CryptoJS.SHA1(user.password).toString()
      }
      console.log(user);
      console.log(reqUser);
      $.ajax({
        url: 'api/auth',
        method: 'PUT',
        contentType: 'application/json',
        data: JSON.stringify(reqUser),

        success: function(resUser) {
          var resUser = resUser.result;
          localStorage.setItem(USERNAME_STORAGE_KEY, resUser.username);
          localStorage.setItem(AUTH_KEY_STORAGE_KEY, resUser.authKey);
          resolve(resUser);
        }
      });
    });
    return primi;
  }

  function userRegister(user) {
    var prom = new Promise(function(resolve, reject) {
      var reqUser = {
        username: user.username,
        passHash: CryptoJS.SHA1(user.password).toString()
      };

      $.ajax({
        url: 'api/users',
        method: 'POST',
        contentType: 'application/json',
        data: JSON.stringify(reqUser),
        success: function(user) {
          resolve(user);
        }
      });
    });
    return prom;
  }

  function userLogout() {
    var promi = new Promise(function(resolve, reject) {
      localStorage.removeItem(AUTH_KEY_STORAGE_KEY);
      localStorage.removeItem(USERNAME_STORAGE_KEY);
      resolve();
    });

    return promi;
  }

  function getCurrentUser() {
    var username = localStorage.getItem(USERNAME_STORAGE_KEY);
    if (!username) {
      return null;
    }
    return {
      username
    };
  }

  function cookiesGet() {
    return jsonRequester.get('api/cookies')
      .then(function(res) {
        return res.result;
      });
  }

  function cookieGet() {
    var options = {
      headers: {
        'x-auth-key': localStorage.getItem(AUTH_KEY_STORAGE_KEY)
      }
    };
    return jsonRequester.get('api/my-cookie', options)
      .then(function(res) {
        return res.result;
      });
  }

  function cookiesAdd(cookie) {
    var options = {
      data: cookie,
      headers: {
        'x-auth-key': localStorage.getItem(AUTH_KEY_STORAGE_KEY)
      }
    };

    return jsonRequester.post('api/cookies', options)
      .then(function(resp) {
        return resp.result;
      });
  }

  function cookieLike(id){
     var options = {
       data: {
         type: 'like'
       },
       headers: {
         'x-auth-key': localStorage.getItem(AUTH_KEY_STORAGE_KEY)
       }
     }
     return jsonRequester.put('api/cookies/' + id, options)
       .then(function(resp) {
         return resp.result;
       });
  }

  function cookieDislike(id){
     var options = {
       data: {
         type: 'dislike'
       },
       headers: {
         'x-auth-key': localStorage.getItem(AUTH_KEY_STORAGE_KEY)
       }
     }
     return jsonRequester.put('api/cookies/' + id, options)
       .then(function(resp) {
         return resp.result;
       });
  }

  function categoriesGet() {
    // var options = {
    //   headers: {
    //     'x-auth-key': localStorage.getItem(AUTH_KEY_STORAGE_KEY)
    //   }
    // };

    return jsonRequester.get('api/categories')
      .then(function(res) {
        console.log('THERE!');
        return res.result;
      });
  }

  return {
    users: {
      login: userLogin,
      register: userRegister,
      logout: userLogout,
      current: getCurrentUser
    },
    cookies: {
      getAll: cookiesGet,
      getCookie: cookieGet,
      add: cookiesAdd,
      like: cookieLike,
      dislike: cookieDislike
    },
    categories: {
      get: categoriesGet
    },
  };
}());
