# EngelsizKartSistemi
  Kalabalık ve düzensiz şehirlerde belirli konumlara yerleştirilmiş kart okuma sistemleri ile engellilere zorluk çıkaran şartların belirlenmesini ve engellinin kimlik tespitinin yapılmasının ardından o engelliye yardım götürülmesini sağlayan bir sistemdir.

  Sistemde, kimlik bilgileri veri tabanından çekilir ve konum belirlemesi yapılır. Veri tabanına kayıtlı olan her kullancıya bir çipli kimlik kartı verilir. Bu kimlik kartları ile, kullanıcılar belirli bölgelere yerleştirilmiş, Raspberry Pi ile bağlantısı yapılmış kart okuyuculara kartlarını okutarak sistemi aktif ederler. Aktif olan sistemteki sunucuya yüklü olan bir program vasıtasıyla kullanıcı ile iletişime geçilir. Bu iletişim yine Raspberry Pi’a bağlanmış olan ses sistemi ile gerçekleştirilir. Sistemin nereden aktifleştirildiği ise Raspberry Pi numarasına göre bulunur. Bu sistem sayesinde kullanıcıya en kısa sürede yardımın ulaştırılması sağlanır.
