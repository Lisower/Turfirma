PGDMP  "    /                }         	   Tyr_Firma    16.3    16.3 1    �           0    0    ENCODING    ENCODING        SET client_encoding = 'UTF8';
                      false            �           0    0 
   STDSTRINGS 
   STDSTRINGS     (   SET standard_conforming_strings = 'on';
                      false            �           0    0 
   SEARCHPATH 
   SEARCHPATH     8   SELECT pg_catalog.set_config('search_path', '', false);
                      false            �           1262    16648 	   Tyr_Firma    DATABASE        CREATE DATABASE "Tyr_Firma" WITH TEMPLATE = template0 ENCODING = 'UTF8' LOCALE_PROVIDER = libc LOCALE = 'Russian_Russia.1251';
    DROP DATABASE "Tyr_Firma";
                postgres    false            �            1255    16772    add_booking_for_new_tourist()    FUNCTION     e  CREATE FUNCTION public.add_booking_for_new_tourist() RETURNS trigger
    LANGUAGE plpgsql
    AS $$
BEGIN
    -- Вставляем новую запись в таблицу Bookings для нового туриста
    -- Выбираем тур с минимальной ценой из доступных сезонов
    INSERT INTO Bookings (TouristID, SeasonID)
    SELECT 
        NEW.TouristID,
        s.SeasonID
    FROM Seasons s
    JOIN Tours t ON s.TourID = t.TourID
    WHERE s.IsSeasonClosed = FALSE AND s.AvailableSpots > 0
    ORDER BY t.Price ASC
    LIMIT 1;
    
    RETURN NEW;
END;
$$;
 4   DROP FUNCTION public.add_booking_for_new_tourist();
       public          postgres    false            �            1259    16693    bookings    TABLE     n   CREATE TABLE public.bookings (
    bookingid integer NOT NULL,
    touristid integer,
    seasonid integer
);
    DROP TABLE public.bookings;
       public         heap    postgres    false            �            1259    16692    bookings_bookingid_seq    SEQUENCE     �   CREATE SEQUENCE public.bookings_bookingid_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 -   DROP SEQUENCE public.bookings_bookingid_seq;
       public          postgres    false    223            �           0    0    bookings_bookingid_seq    SEQUENCE OWNED BY     Q   ALTER SEQUENCE public.bookings_bookingid_seq OWNED BY public.bookings.bookingid;
          public          postgres    false    222            �            1259    16710    payments    TABLE     �   CREATE TABLE public.payments (
    paymentid integer NOT NULL,
    bookingid integer,
    paymentdate date NOT NULL,
    amount money NOT NULL
);
    DROP TABLE public.payments;
       public         heap    postgres    false            �            1259    16709    payments_paymentid_seq    SEQUENCE     �   CREATE SEQUENCE public.payments_paymentid_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 -   DROP SEQUENCE public.payments_paymentid_seq;
       public          postgres    false    225            �           0    0    payments_paymentid_seq    SEQUENCE OWNED BY     Q   ALTER SEQUENCE public.payments_paymentid_seq OWNED BY public.payments.paymentid;
          public          postgres    false    224            �            1259    16680    seasons    TABLE     �   CREATE TABLE public.seasons (
    seasonid integer NOT NULL,
    tourid integer,
    startdate date NOT NULL,
    enddate date NOT NULL,
    isseasonclosed boolean DEFAULT false,
    availablespots integer
);
    DROP TABLE public.seasons;
       public         heap    postgres    false            �            1259    16679    seasons_seasonid_seq    SEQUENCE     �   CREATE SEQUENCE public.seasons_seasonid_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 +   DROP SEQUENCE public.seasons_seasonid_seq;
       public          postgres    false    221            �           0    0    seasons_seasonid_seq    SEQUENCE OWNED BY     M   ALTER SEQUENCE public.seasons_seasonid_seq OWNED BY public.seasons.seasonid;
          public          postgres    false    220            �            1259    16658    touristinfo    TABLE     �   CREATE TABLE public.touristinfo (
    touristid integer NOT NULL,
    passportseries text,
    city text,
    country text,
    phone text,
    postalcode integer
);
    DROP TABLE public.touristinfo;
       public         heap    postgres    false            �            1259    16650    tourists    TABLE     �   CREATE TABLE public.tourists (
    touristid integer NOT NULL,
    lastname text NOT NULL,
    firstname text NOT NULL,
    middlename text
);
    DROP TABLE public.tourists;
       public         heap    postgres    false            �            1259    16649    tourists_touristid_seq    SEQUENCE     �   CREATE SEQUENCE public.tourists_touristid_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 -   DROP SEQUENCE public.tourists_touristid_seq;
       public          postgres    false    216            �           0    0    tourists_touristid_seq    SEQUENCE OWNED BY     Q   ALTER SEQUENCE public.tourists_touristid_seq OWNED BY public.tourists.touristid;
          public          postgres    false    215            �            1259    16671    tours    TABLE     ~   CREATE TABLE public.tours (
    tourid integer NOT NULL,
    tourname text NOT NULL,
    price money,
    description text
);
    DROP TABLE public.tours;
       public         heap    postgres    false            �            1259    16670    tours_tourid_seq    SEQUENCE     �   CREATE SEQUENCE public.tours_tourid_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 '   DROP SEQUENCE public.tours_tourid_seq;
       public          postgres    false    219            �           0    0    tours_tourid_seq    SEQUENCE OWNED BY     E   ALTER SEQUENCE public.tours_tourid_seq OWNED BY public.tours.tourid;
          public          postgres    false    218            7           2604    16696    bookings bookingid    DEFAULT     x   ALTER TABLE ONLY public.bookings ALTER COLUMN bookingid SET DEFAULT nextval('public.bookings_bookingid_seq'::regclass);
 A   ALTER TABLE public.bookings ALTER COLUMN bookingid DROP DEFAULT;
       public          postgres    false    222    223    223            8           2604    16713    payments paymentid    DEFAULT     x   ALTER TABLE ONLY public.payments ALTER COLUMN paymentid SET DEFAULT nextval('public.payments_paymentid_seq'::regclass);
 A   ALTER TABLE public.payments ALTER COLUMN paymentid DROP DEFAULT;
       public          postgres    false    225    224    225            5           2604    16683    seasons seasonid    DEFAULT     t   ALTER TABLE ONLY public.seasons ALTER COLUMN seasonid SET DEFAULT nextval('public.seasons_seasonid_seq'::regclass);
 ?   ALTER TABLE public.seasons ALTER COLUMN seasonid DROP DEFAULT;
       public          postgres    false    220    221    221            3           2604    16653    tourists touristid    DEFAULT     x   ALTER TABLE ONLY public.tourists ALTER COLUMN touristid SET DEFAULT nextval('public.tourists_touristid_seq'::regclass);
 A   ALTER TABLE public.tourists ALTER COLUMN touristid DROP DEFAULT;
       public          postgres    false    215    216    216            4           2604    16674    tours tourid    DEFAULT     l   ALTER TABLE ONLY public.tours ALTER COLUMN tourid SET DEFAULT nextval('public.tours_tourid_seq'::regclass);
 ;   ALTER TABLE public.tours ALTER COLUMN tourid DROP DEFAULT;
       public          postgres    false    219    218    219            �          0    16693    bookings 
   TABLE DATA           B   COPY public.bookings (bookingid, touristid, seasonid) FROM stdin;
    public          postgres    false    223   �9       �          0    16710    payments 
   TABLE DATA           M   COPY public.payments (paymentid, bookingid, paymentdate, amount) FROM stdin;
    public          postgres    false    225   �9       �          0    16680    seasons 
   TABLE DATA           g   COPY public.seasons (seasonid, tourid, startdate, enddate, isseasonclosed, availablespots) FROM stdin;
    public          postgres    false    221   #:       �          0    16658    touristinfo 
   TABLE DATA           b   COPY public.touristinfo (touristid, passportseries, city, country, phone, postalcode) FROM stdin;
    public          postgres    false    217   �:       �          0    16650    tourists 
   TABLE DATA           N   COPY public.tourists (touristid, lastname, firstname, middlename) FROM stdin;
    public          postgres    false    216   Y;       �          0    16671    tours 
   TABLE DATA           E   COPY public.tours (tourid, tourname, price, description) FROM stdin;
    public          postgres    false    219   <       �           0    0    bookings_bookingid_seq    SEQUENCE SET     D   SELECT pg_catalog.setval('public.bookings_bookingid_seq', 5, true);
          public          postgres    false    222            �           0    0    payments_paymentid_seq    SEQUENCE SET     D   SELECT pg_catalog.setval('public.payments_paymentid_seq', 5, true);
          public          postgres    false    224            �           0    0    seasons_seasonid_seq    SEQUENCE SET     B   SELECT pg_catalog.setval('public.seasons_seasonid_seq', 5, true);
          public          postgres    false    220            �           0    0    tourists_touristid_seq    SEQUENCE SET     D   SELECT pg_catalog.setval('public.tourists_touristid_seq', 5, true);
          public          postgres    false    215            �           0    0    tours_tourid_seq    SEQUENCE SET     >   SELECT pg_catalog.setval('public.tours_tourid_seq', 5, true);
          public          postgres    false    218            B           2606    16698    bookings bookings_pkey 
   CONSTRAINT     [   ALTER TABLE ONLY public.bookings
    ADD CONSTRAINT bookings_pkey PRIMARY KEY (bookingid);
 @   ALTER TABLE ONLY public.bookings DROP CONSTRAINT bookings_pkey;
       public            postgres    false    223            D           2606    16715    payments payments_pkey 
   CONSTRAINT     [   ALTER TABLE ONLY public.payments
    ADD CONSTRAINT payments_pkey PRIMARY KEY (paymentid);
 @   ALTER TABLE ONLY public.payments DROP CONSTRAINT payments_pkey;
       public            postgres    false    225            @           2606    16686    seasons seasons_pkey 
   CONSTRAINT     X   ALTER TABLE ONLY public.seasons
    ADD CONSTRAINT seasons_pkey PRIMARY KEY (seasonid);
 >   ALTER TABLE ONLY public.seasons DROP CONSTRAINT seasons_pkey;
       public            postgres    false    221            <           2606    16664    touristinfo touristinfo_pkey 
   CONSTRAINT     a   ALTER TABLE ONLY public.touristinfo
    ADD CONSTRAINT touristinfo_pkey PRIMARY KEY (touristid);
 F   ALTER TABLE ONLY public.touristinfo DROP CONSTRAINT touristinfo_pkey;
       public            postgres    false    217            :           2606    16657    tourists tourists_pkey 
   CONSTRAINT     [   ALTER TABLE ONLY public.tourists
    ADD CONSTRAINT tourists_pkey PRIMARY KEY (touristid);
 @   ALTER TABLE ONLY public.tourists DROP CONSTRAINT tourists_pkey;
       public            postgres    false    216            >           2606    16678    tours tours_pkey 
   CONSTRAINT     R   ALTER TABLE ONLY public.tours
    ADD CONSTRAINT tours_pkey PRIMARY KEY (tourid);
 :   ALTER TABLE ONLY public.tours DROP CONSTRAINT tours_pkey;
       public            postgres    false    219            J           2620    16773    tourists tourist_insert_trigger    TRIGGER     �   CREATE TRIGGER tourist_insert_trigger AFTER INSERT ON public.tourists FOR EACH ROW EXECUTE FUNCTION public.add_booking_for_new_tourist();
 8   DROP TRIGGER tourist_insert_trigger ON public.tourists;
       public          postgres    false    216    226            G           2606    16704    bookings bookings_seasonid_fkey    FK CONSTRAINT     �   ALTER TABLE ONLY public.bookings
    ADD CONSTRAINT bookings_seasonid_fkey FOREIGN KEY (seasonid) REFERENCES public.seasons(seasonid);
 I   ALTER TABLE ONLY public.bookings DROP CONSTRAINT bookings_seasonid_fkey;
       public          postgres    false    4672    223    221            H           2606    16699     bookings bookings_touristid_fkey    FK CONSTRAINT     �   ALTER TABLE ONLY public.bookings
    ADD CONSTRAINT bookings_touristid_fkey FOREIGN KEY (touristid) REFERENCES public.tourists(touristid);
 J   ALTER TABLE ONLY public.bookings DROP CONSTRAINT bookings_touristid_fkey;
       public          postgres    false    4666    223    216            I           2606    16716     payments payments_bookingid_fkey    FK CONSTRAINT     �   ALTER TABLE ONLY public.payments
    ADD CONSTRAINT payments_bookingid_fkey FOREIGN KEY (bookingid) REFERENCES public.bookings(bookingid);
 J   ALTER TABLE ONLY public.payments DROP CONSTRAINT payments_bookingid_fkey;
       public          postgres    false    225    4674    223            F           2606    16687    seasons seasons_tourid_fkey    FK CONSTRAINT     }   ALTER TABLE ONLY public.seasons
    ADD CONSTRAINT seasons_tourid_fkey FOREIGN KEY (tourid) REFERENCES public.tours(tourid);
 E   ALTER TABLE ONLY public.seasons DROP CONSTRAINT seasons_tourid_fkey;
       public          postgres    false    4670    221    219            E           2606    16665 &   touristinfo touristinfo_touristid_fkey    FK CONSTRAINT     �   ALTER TABLE ONLY public.touristinfo
    ADD CONSTRAINT touristinfo_touristid_fkey FOREIGN KEY (touristid) REFERENCES public.tourists(touristid);
 P   ALTER TABLE ONLY public.touristinfo DROP CONSTRAINT touristinfo_touristid_fkey;
       public          postgres    false    217    4666    216            �   (   x�3�4�4�2�B.cNcN.NNS.SNS�x� K�0      �   R   x�U���0���

 �lǁ�h�⨅�P���h�
�Ѽ0
��&���)�ֆ�H��iG�����:���e��S��&"/XdA      �   S   x�E��� ���UH�]���_����ɊBab9ɝ$�:�q���X����&�]�ОT�X�(�S9<�z�|.�?`)�      �   �   x�u�A�0E��Sto4
��a�&���z�	����F� K\��$����ĉOm�t���C�'�]�x�U^r�U�$v�3	�El����}��}�׸�kyڸ��� SVP�ҩ̓����+���hfG'���):SHFOJ�ƊZ������
Ti��@�P�%#�ک0�,�>Z/�|�N	�c����      �   �   x�U�]
�0��7������
�hD�!6[�3���٦�����6c�-:���s�t�&�+����-/8�S$�	nL
�y�����P����Z����ӚICJ3�I�xpB�͇SR�����_,�{kn�l�8��vM��]�8��s��ĥ      �   �   x���MNA��է���ƍ�00Y�ĘBHX�tt�4��'x�F����:U���W�ܰ�� qv�q�sD�ڲ�!�B�׆M
N9�8 z�Qs�����!J=���'(��vm�#ސ�����FK��Ѻ�o�\�3l�?��}K���$Q}Y
�\����T��{���x�o���o>�麆����Ϫs��eJUΒ�E)��9�H�(�<-���s��<e     