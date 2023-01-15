PGDMP     +                     {            Repairs    14.5    14.5                 0    0    ENCODING    ENCODING        SET client_encoding = 'UTF8';
                      false                       0    0 
   STDSTRINGS 
   STDSTRINGS     (   SET standard_conforming_strings = 'on';
                      false                       0    0 
   SEARCHPATH 
   SEARCHPATH     8   SELECT pg_catalog.set_config('search_path', '', false);
                      false                       1262    16394    Repairs    DATABASE     f   CREATE DATABASE "Repairs" WITH TEMPLATE = template0 ENCODING = 'UTF8' LOCALE = 'Russian_Russia.1251';
    DROP DATABASE "Repairs";
                postgres    false            �            1259    16545 	   ATMModels    TABLE     ?   CREATE TABLE public."ATMModels" (
    "Model" text NOT NULL
);
    DROP TABLE public."ATMModels";
       public         heap    postgres    false            �            1259    16531    ATMs    TABLE     �   CREATE TABLE public."ATMs" (
    "ATMID" text NOT NULL,
    "Address" text NOT NULL,
    "Model" text NOT NULL,
    "Region" text NOT NULL
);
    DROP TABLE public."ATMs";
       public         heap    postgres    false            �            1259    16538 
   Categories    TABLE     G   CREATE TABLE public."Categories" (
    "CategoryName" text NOT NULL
);
     DROP TABLE public."Categories";
       public         heap    postgres    false            �            1259    16568 	   Engineers    TABLE     F   CREATE TABLE public."Engineers" (
    "EngineerName" text NOT NULL
);
    DROP TABLE public."Engineers";
       public         heap    postgres    false            �            1259    16552    Regions    TABLE     B   CREATE TABLE public."Regions" (
    "RegionName" text NOT NULL
);
    DROP TABLE public."Regions";
       public         heap    postgres    false            �            1259    16560    Repairs    TABLE     �   CREATE TABLE public."Repairs" (
    "RepairID" integer NOT NULL,
    "ATMID" character varying(8) NOT NULL,
    "Category" text NOT NULL,
    "Engineer" text NOT NULL,
    "Date" date NOT NULL,
    "Comment" text
);
    DROP TABLE public."Repairs";
       public         heap    postgres    false            �            1259    16559    Repairs_RepairID_seq    SEQUENCE     �   CREATE SEQUENCE public."Repairs_RepairID_seq"
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 -   DROP SEQUENCE public."Repairs_RepairID_seq";
       public          postgres    false    218                       0    0    Repairs_RepairID_seq    SEQUENCE OWNED BY     S   ALTER SEQUENCE public."Repairs_RepairID_seq" OWNED BY public."Repairs"."RepairID";
          public          postgres    false    217            t           2604    16563    Repairs RepairID    DEFAULT     z   ALTER TABLE ONLY public."Repairs" ALTER COLUMN "RepairID" SET DEFAULT nextval('public."Repairs_RepairID_seq"'::regclass);
 C   ALTER TABLE public."Repairs" ALTER COLUMN "RepairID" DROP DEFAULT;
       public          postgres    false    218    217    218                      0    16545 	   ATMModels 
   TABLE DATA           .   COPY public."ATMModels" ("Model") FROM stdin;
    public          postgres    false    215   �"                 0    16531    ATMs 
   TABLE DATA           G   COPY public."ATMs" ("ATMID", "Address", "Model", "Region") FROM stdin;
    public          postgres    false    213   \#                 0    16538 
   Categories 
   TABLE DATA           6   COPY public."Categories" ("CategoryName") FROM stdin;
    public          postgres    false    214   �&                 0    16568 	   Engineers 
   TABLE DATA           5   COPY public."Engineers" ("EngineerName") FROM stdin;
    public          postgres    false    219   .)                 0    16552    Regions 
   TABLE DATA           1   COPY public."Regions" ("RegionName") FROM stdin;
    public          postgres    false    216   �)                 0    16560    Repairs 
   TABLE DATA           c   COPY public."Repairs" ("RepairID", "ATMID", "Category", "Engineer", "Date", "Comment") FROM stdin;
    public          postgres    false    218   �)                   0    0    Repairs_RepairID_seq    SEQUENCE SET     E   SELECT pg_catalog.setval('public."Repairs_RepairID_seq"', 82, true);
          public          postgres    false    217            z           2606    16551    ATMModels ATMModels_pkey 
   CONSTRAINT     _   ALTER TABLE ONLY public."ATMModels"
    ADD CONSTRAINT "ATMModels_pkey" PRIMARY KEY ("Model");
 F   ALTER TABLE ONLY public."ATMModels" DROP CONSTRAINT "ATMModels_pkey";
       public            postgres    false    215            v           2606    16657    ATMs ATMs_pkey 
   CONSTRAINT     U   ALTER TABLE ONLY public."ATMs"
    ADD CONSTRAINT "ATMs_pkey" PRIMARY KEY ("ATMID");
 <   ALTER TABLE ONLY public."ATMs" DROP CONSTRAINT "ATMs_pkey";
       public            postgres    false    213            x           2606    16544    Categories Devices_pkey 
   CONSTRAINT     e   ALTER TABLE ONLY public."Categories"
    ADD CONSTRAINT "Devices_pkey" PRIMARY KEY ("CategoryName");
 E   ALTER TABLE ONLY public."Categories" DROP CONSTRAINT "Devices_pkey";
       public            postgres    false    214            �           2606    16574    Engineers Engineer_pkey 
   CONSTRAINT     e   ALTER TABLE ONLY public."Engineers"
    ADD CONSTRAINT "Engineer_pkey" PRIMARY KEY ("EngineerName");
 E   ALTER TABLE ONLY public."Engineers" DROP CONSTRAINT "Engineer_pkey";
       public            postgres    false    219            |           2606    16558    Regions Regions_pkey 
   CONSTRAINT     `   ALTER TABLE ONLY public."Regions"
    ADD CONSTRAINT "Regions_pkey" PRIMARY KEY ("RegionName");
 B   ALTER TABLE ONLY public."Regions" DROP CONSTRAINT "Regions_pkey";
       public            postgres    false    216            ~           2606    16567    Repairs Repairs_pkey 
   CONSTRAINT     ^   ALTER TABLE ONLY public."Repairs"
    ADD CONSTRAINT "Repairs_pkey" PRIMARY KEY ("RepairID");
 B   ALTER TABLE ONLY public."Repairs" DROP CONSTRAINT "Repairs_pkey";
       public            postgres    false    218                       1259    16580    fki_Engineer    INDEX     J   CREATE INDEX "fki_Engineer" ON public."Repairs" USING btree ("Engineer");
 "   DROP INDEX public."fki_Engineer";
       public            postgres    false    218            �           2606    16658    Repairs ATMs    FK CONSTRAINT     �   ALTER TABLE ONLY public."Repairs"
    ADD CONSTRAINT "ATMs" FOREIGN KEY ("ATMID") REFERENCES public."ATMs"("ATMID") ON UPDATE CASCADE ON DELETE RESTRICT NOT VALID;
 :   ALTER TABLE ONLY public."Repairs" DROP CONSTRAINT "ATMs";
       public          postgres    false    213    218    3190            �           2606    16646    Repairs Devices    FK CONSTRAINT     �   ALTER TABLE ONLY public."Repairs"
    ADD CONSTRAINT "Devices" FOREIGN KEY ("Category") REFERENCES public."Categories"("CategoryName") ON UPDATE CASCADE ON DELETE RESTRICT NOT VALID;
 =   ALTER TABLE ONLY public."Repairs" DROP CONSTRAINT "Devices";
       public          postgres    false    3192    218    214            �           2606    16651    Repairs Engineers    FK CONSTRAINT     �   ALTER TABLE ONLY public."Repairs"
    ADD CONSTRAINT "Engineers" FOREIGN KEY ("Engineer") REFERENCES public."Engineers"("EngineerName") ON UPDATE CASCADE ON DELETE RESTRICT NOT VALID;
 ?   ALTER TABLE ONLY public."Repairs" DROP CONSTRAINT "Engineers";
       public          postgres    false    219    218    3201            �           2606    16631    ATMs Models    FK CONSTRAINT     �   ALTER TABLE ONLY public."ATMs"
    ADD CONSTRAINT "Models" FOREIGN KEY ("Model") REFERENCES public."ATMModels"("Model") ON UPDATE CASCADE ON DELETE RESTRICT NOT VALID;
 9   ALTER TABLE ONLY public."ATMs" DROP CONSTRAINT "Models";
       public          postgres    false    3194    215    213            �           2606    16636    ATMs Regions    FK CONSTRAINT     �   ALTER TABLE ONLY public."ATMs"
    ADD CONSTRAINT "Regions" FOREIGN KEY ("Region") REFERENCES public."Regions"("RegionName") ON UPDATE CASCADE ON DELETE RESTRICT NOT VALID;
 :   ALTER TABLE ONLY public."ATMs" DROP CONSTRAINT "Regions";
       public          postgres    false    3196    216    213               \   x��sR0332��3��(���03L-�a�P��an������`b`b c ��lS$5@6�#S� P.h�
�Ռ+F��� Ŝ(=         �  x��WMO�@='�b���D��wm�9�B%.�����H �)UJiK�I����f�Qg�kgٵ[Z$@��{�3o�L(�g4m��M�0����a���1^��H8��9�{�1l�����I"/_mRM��	-�0�;З���f�'p��'0�i��p�����*��?���~s���hD�l,�Ul�����$'��9I��#�c_@&w���RANU��^y��=d�ˣ�!�\�u&[!��S76<�N�r��W����sl�I�gOzb�AncxL��{��p'�ԣ��e�^l��'t�h-pO�=�z�U�-P��Z���S�%�ԡ�¤���\�T�-8�'�[��:�<�,!��`! .���ݽ�*��S�x���*�\I+T$��k��]�BܫN@�Lif$��Y��h\��SOb�)�i�%���#���]~���F�.���L�{��05l���Y�O��-�Y�t)�G݀�$��.�CT����+���#u`j�8ny�PT�[D8��#rdft�V����Q>`�����瘜.&]1GM�CՇ�ݙ�Yy=C����ע�7p�K�m@�D��鋡<xk�>׉p>����;�\�ޝ���}�H�D�YK	�L�<���l���PB�<i�3DU<��9��>�]lTe��y�]�z��1�hw��X��PQizA�Q%Bku ���Xn�)�]ۮ	>�.�|H��e��H����A�idn�q����(����fKc����}��{k���MM�E<�+��?	�0[���Z�k}"�S��LӘ������4~EC#��zJ��8fj�]ޘ*T�*p����Gfí� ���\��b�|�*���U���^�&;V��\��Ξ����r�`��j9_��7�v���=�o�         ,  x��S�n�P��+��>�hC��dT�.Qj�JQ�p��-�j(*B�'�[�n�_��#f։�B���ݝ���'����K�gN�����/�j̓�N&��B
�*8{?<�)�������<���p�� �x�G.��3�(�'E�1�S�����(7���Dp���$�dS�Lu�[R��%���Б�:��a�>���
C�R�W���t��\
�7[�v� r/�<���>��캭�O�n;
j�� 6��y����%��	������51As�v&b�H��2� ��1��9GQ�1� TDұ�em'���%-���a܎:�V7�}�W�M.���<?GU���f��$2���F� ij,&�����I����`�}�-@m\�����0���zb�)-��Xn�ɪ	�(����]':�2k���=�����+?VJ*���j��K'S�~C1��dn� ���X��맒��YC��6�_�����Q�}ԉ�8x��J�9�Q��Wg�g=�� �׮�ֹ=5:���E��{�6?=���{��<�/���         _   x���	�@D�b+؊,�h�/0010����v��0����J^�Uܜ\B���9x8�%=;aSok�V�:�2:�ɮ��7���!|�=L         K   x�ȱ	�0���Ɖ�F�,Ep���F3�wy�+���>�S|���4NL>�|"��_Ia�6.���h�0         u  x��Y�n�V]�~�EV6`	|�Z�q�h� }m�)-�I\;m���Wᴎ��$�Q��zԲ,K�p�G=3��(R�#�Eݙ9s��ܑ]1�t-î�7j��U?l�Q����Q-5��'������TG5��V�˪~��*�O~��ϵ$~I�Zk2�Q���΄�h[Fݯ�#<��{��y��N�:Vg���аY5�i�0çՒC�8����՘��I�pO����?>���-ܫ	ӛ�A�/���ΥzSS/' X�BMؑ�3��;f���� ��ދ��#���-'�S\�@����B�B�"�3¡�] �T�	�N ��K�X��olo6�m7�V+��>gKrJ"ȇ��B��qEh���IϽD4]<7b��:��_�Y�[d	f��mT�_x�C1�[ƈ����dd�S�0�^�0�9�jY���9�'�2C�|���W��RЫ�7cx��a�#�3��A�§��[����;9Q���=u>��~*a��ח+`L�=:��Y����59��1.T�>+Wp���ڍΓ+\�'pa��}�������r�kع�e��D`��R��VMsuH�F���5G��kT�4��z��V��C0��]M��n��ӹ�½55|L�K�q"YK�Q�ݱ싸S��j�	Ͽ:�LՔI�>$��L�t�M�����r(Y'r �HE�3��j2[b��3�p�� �D��O����'�qc�����cyj͈��/>Z]ܥuK���F㮼��i�NC�vy�є��ol�ٺ��ng�K�mp���/��nJ��wX��,�#M�c`�ú�tҼ
f�J
�V�.|�U�WʧD<g+����Y��h	�Ҏ-T�e����w̫�Kg�k�[,�DCM��C�\'azF�&���:ڇ�>����:�Vx
|>��.+��	΁��T�V�V��9]��P�?� ������Q��W5�����Y@v��癩�����T$2�I=2_jL͞�Ŋ9��'� 4�<�p�(+;�>��a6�5�$���kNB�E�K�ʕ�n^��mq�u�5���ד�4e�%P�h	���pQ)ڹ��(0$9��̲����J���^�j��i��um�4�z|�݀���{
Q�Ł�e�	��}���`e#�=�G4�q��zOE-X�\�X�
׊������Y�E����Ni���x4����v�7�w�'|)-�Fvx��4_on6�䃭��mo��z \��x��+��ϟ�&�
�JA�ݵ�:��x�۫���:��z��0UØ��)��E��g��C|���^$'�"ģ�m.���<�osh���[� n��Nʣ���Q��;o��	tz���KT�~5韢bwҎ��8��
^<*���w�߾��j�ٷsJ���(�~j_6{1{;�;K@�2%K�d��/����b��{q�F;w�����F�R}�j�i�x�6��!i��>!}����0K�4N�@������2�L��"��F����(�ى��4"����.�W��o�H�l��}����k���y-����ٍ��,G���Hb��ޒ����Ń���¢��N��\����ٽ��Z�8�^����|�������H/���zuԸ�
4S�e�)5;�_Qdbb�����B��(�v4�����)á���/i��Ic���-v���D/���t��`J���;k/!�n��6˥�~�K	�!�%��I�$�}STd,������j���}�h�-��Ô�±S~�4�S���<S����e`
��0w��kSW,�I܋,��;��ua�f5cۻ��1���8����&�X���o�����vYw���e��.��\�P��$�N�7�8�H_g�"|;5����sg�1�N�:lH����u	h�����&l�lOgW�[u��4���jB��+��B     